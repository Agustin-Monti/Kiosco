using MetroFramework.Forms;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace KioscoApp
{
    public partial class Form1 : MetroForm
    {
        string connectionString = "Data Source=kiosco.db;Version=3;";

        private FilterInfoCollection dispositivosVideo;
        private VideoCaptureDevice camaraSeleccionada;
        private BarcodeReader lectorCodigo;
        private bool leyendo = false;

        public Form1()
        {
            InitializeComponent();
            CrearBaseDeDatos();
            InsertarProductosDePrueba();
            CargarCamaras();
            HacerBackup();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void CrearBaseDeDatos()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    CREATE TABLE IF NOT EXISTS Productos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CodigoBarras TEXT,
                        Descripcion TEXT,
                        PrecioCosto REAL,
                        PrecioVenta REAL,
                        Stock INTEGER
                    );

                    CREATE TABLE IF NOT EXISTS Ventas (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Fecha TEXT,
                        Total REAL,
                        TipoPago TEXT
                    );

                    CREATE TABLE IF NOT EXISTS DetalleVenta (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        VentaId INTEGER,
                        ProductoId INTEGER,
                        Cantidad INTEGER,
                        PrecioUnitario REAL
                    );
                ";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void InsertarProductosDePrueba()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string check = "SELECT COUNT(*) FROM Productos";
                SQLiteCommand cmdCheck = new SQLiteCommand(check, conn);
                int cantidad = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (cantidad == 0)
                {
                    string sql = @"
                        INSERT INTO Productos (CodigoBarras, Descripcion, PrecioCosto, PrecioVenta, Stock)
                        VALUES
                        ('7790895000995', 'Coca-Cola 500ml', 450, 850, 50),
                        ('7791234567890', 'Pitusas', 100, 200, 100),
                        ('7799876543210', 'Marlboro Box', 700, 980, 30),
                        ('7791111222333', 'Alfajor Guaymallén', 80, 150, 60),
                        ('7792222333444', 'Papas Lays 150g', 300, 600, 25),
                        ('7793333444555', 'Agua Villavicencio 1L', 200, 400, 40),
                        ('7794444555666', 'Caramelos Sugus', 30, 80, 200);
                    ";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        // ==================== CÁMARA ====================

        private void CargarCamaras()
        {
            dispositivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            cmbCamara.Items.Clear();
            cmbCamara.Items.Add("Sin cámara");

            foreach (FilterInfo dispositivo in dispositivosVideo)
            {
                cmbCamara.Items.Add(dispositivo.Name);
            }

            cmbCamara.SelectedIndex = 0;
        }

        private void cmbCamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (camaraSeleccionada != null && camaraSeleccionada.IsRunning)
            {
                camaraSeleccionada.SignalToStop();
                camaraSeleccionada = null;
            }

            if (cmbCamara.SelectedIndex > 0)
            {
                camaraSeleccionada = new VideoCaptureDevice(dispositivosVideo[cmbCamara.SelectedIndex - 1].MonikerString);
                camaraSeleccionada.NewFrame += Camara_NuevoFrame;
                camaraSeleccionada.Start();
                timerCamara.Start();
            }
            else
            {
                timerCamara.Stop();
                pictureBoxCamara.Image = null;
            }
        }

        private void Camara_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamara.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timerCamara_Tick(object sender, EventArgs e)
        {
            if (leyendo) return;

            if (pictureBoxCamara.Image != null)
            {
                lectorCodigo = new BarcodeReader();
                Result resultado = lectorCodigo.Decode((Bitmap)pictureBoxCamara.Image);

                if (resultado != null)
                {
                    leyendo = true;
                    string codigo = resultado.Text;

                    this.Invoke(new Action(() =>
                    {
                        AgregarProductoAGrilla(codigo);
                        txtCodigoBarras.Clear();
                    }));

                    // Esperar 2 segundos antes de volver a leer
                    Task.Delay(2000).ContinueWith(t => { leyendo = false; });
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camaraSeleccionada != null && camaraSeleccionada.IsRunning)
            {
                camaraSeleccionada.SignalToStop();
            }
        }

        // ==================== VENTA ====================

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = txtCodigoBarras.Text.Trim();

                if (!string.IsNullOrEmpty(codigo))
                {
                    AgregarProductoAGrilla(codigo);
                    txtCodigoBarras.Clear();
                }

                e.SuppressKeyPress = true;
            }
        }

        private void AgregarProductoAGrilla(string codigo)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Productos WHERE CodigoBarras = @codigo";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int stock = Convert.ToInt32(reader["Stock"]);

                        if (stock <= 0)
                        {
                            MessageBox.Show("Producto sin stock.");
                            return;
                        }

                        string descripcion = reader["Descripcion"].ToString();
                        decimal precio = Convert.ToDecimal(reader["PrecioVenta"]);

                        // Cerrar el reader antes de modificar la grilla
                        reader.Close();

                        // Revisar si el producto ya está en la grilla
                        foreach (DataGridViewRow fila in dgvVenta.Rows)
                        {
                            if (fila.Cells["ColCodigo"].Value != null &&
                                fila.Cells["ColCodigo"].Value.ToString() == codigo)
                            {
                                int cantidad = 1;
                                int.TryParse(txtCantidad.Text, out cantidad);
                                if (cantidad < 1) cantidad = 1;

                                int cantActual = Convert.ToInt32(fila.Cells["ColCantidad"].Value);
                                cantActual += cantidad;
                                fila.Cells["ColCantidad"].Value = cantActual;
                                fila.Cells["ColSubtotal"].Value = cantActual * precio;
                                ActualizarTotal();
                                ReproducirSonido();
                                return;
                            }
                        }

                        int cantidadNueva = 1;
                        int.TryParse(txtCantidad.Text, out cantidadNueva);
                        if (cantidadNueva < 1) cantidadNueva = 1;

                        dgvVenta.Rows.Add(codigo, descripcion, cantidadNueva, precio.ToString("0.00"), (cantidadNueva * precio).ToString("0.00"));
                        ActualizarTotal();
                        ReproducirSonido();
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();

                        DialogResult resultado = MessageBox.Show(
                            "Producto no encontrado.\n\n¿Querés agregarlo al sistema?",
                            "Producto nuevo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            AgregarProductoNuevoForm nuevoProducto = new AgregarProductoNuevoForm(codigo);
                            if (nuevoProducto.ShowDialog() == DialogResult.OK)
                            {
                                // Una vez agregado, lo buscamos de nuevo
                                AgregarProductoAGrilla(codigo);
                            }
                        }
                        return;
                    }
                }
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["ColSubtotal"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["ColSubtotal"].Value);
                }
            }

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        // ==================== COBRO ====================

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count == 0 || dgvVenta.Rows[0].Cells["ColCodigo"].Value == null)
            {
                MessageBox.Show("No hay productos en la venta.");
                return;
            }

            decimal total = 0;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["ColSubtotal"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["ColSubtotal"].Value);
                }
            }

            // Abrir ventana de cobro
            // Crear tabla con los productos actuales
            DataTable productos = new DataTable();
            productos.Columns.Add("Cantidad");
            productos.Columns.Add("Descripcion");
            productos.Columns.Add("PrecioUnitario");
            productos.Columns.Add("Subtotal");

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["ColCodigo"].Value != null)
                {
                    productos.Rows.Add(
                        fila.Cells["ColCantidad"].Value,
                        fila.Cells["ColDescripcion"].Value,
                        Convert.ToDecimal(fila.Cells["ColPrecio"].Value),
                        Convert.ToDecimal(fila.Cells["ColSubtotal"].Value)
                    );
                }
            }

            CobroForm cobroForm = new CobroForm(total);
            cobroForm.ProductosVenta = productos;
            cobroForm.ShowDialog();

            if (cobroForm.CobroExitoso)
            {
                // Hace todo junto: descuenta stock y guarda venta
                GuardarVentaCompleta(cobroForm.TipoPago, total);

                // Limpiar la grilla
                dgvVenta.Rows.Clear();
                lblTotal.Text = "Total: $0.00";

                MessageBox.Show("¡Venta realizada con éxito!");
            }
        }

        private void GuardarVentaCompleta(string tipoPago, decimal total)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Descontar stock
                        foreach (DataGridViewRow fila in dgvVenta.Rows)
                        {
                            if (fila.Cells["ColCodigo"].Value != null)
                            {
                                string codigo = fila.Cells["ColCodigo"].Value.ToString();
                                int cantidad = Convert.ToInt32(fila.Cells["ColCantidad"].Value);

                                string sqlStock = "UPDATE Productos SET Stock = Stock - @cantidad WHERE CodigoBarras = @codigo";
                                SQLiteCommand cmdStock = new SQLiteCommand(sqlStock, conn);
                                cmdStock.Parameters.AddWithValue("@cantidad", cantidad);
                                cmdStock.Parameters.AddWithValue("@codigo", codigo);
                                cmdStock.ExecuteNonQuery();
                            }
                        }

                        // 2. Insertar la venta
                        string sqlVenta = "INSERT INTO Ventas (Fecha, Total, TipoPago) VALUES (@fecha, @total, @tipoPago)";
                        SQLiteCommand cmdVenta = new SQLiteCommand(sqlVenta, conn);
                        cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmdVenta.Parameters.AddWithValue("@total", total);
                        cmdVenta.Parameters.AddWithValue("@tipoPago", tipoPago);
                        cmdVenta.ExecuteNonQuery();

                        // 3. Obtener el ID de la venta
                        string sqlId = "SELECT last_insert_rowid()";
                        SQLiteCommand cmdId = new SQLiteCommand(sqlId, conn);
                        int ventaId = Convert.ToInt32(cmdId.ExecuteScalar());

                        // 4. Insertar detalle de cada producto
                        foreach (DataGridViewRow fila in dgvVenta.Rows)
                        {
                            if (fila.Cells["ColCodigo"].Value != null)
                            {
                                string codigo = fila.Cells["ColCodigo"].Value.ToString();
                                int cantidad = Convert.ToInt32(fila.Cells["ColCantidad"].Value);
                                decimal precioUnitario = Convert.ToDecimal(fila.Cells["ColPrecio"].Value);

                                string sqlProdId = "SELECT Id FROM Productos WHERE CodigoBarras = @codigo";
                                SQLiteCommand cmdProdId = new SQLiteCommand(sqlProdId, conn);
                                cmdProdId.Parameters.AddWithValue("@codigo", codigo);
                                int productoId = Convert.ToInt32(cmdProdId.ExecuteScalar());

                                string sqlDetalle = "INSERT INTO DetalleVenta (VentaId, ProductoId, Cantidad, PrecioUnitario) VALUES (@ventaId, @productoId, @cantidad, @precioUnitario)";
                                SQLiteCommand cmdDetalle = new SQLiteCommand(sqlDetalle, conn);
                                cmdDetalle.Parameters.AddWithValue("@ventaId", ventaId);
                                cmdDetalle.Parameters.AddWithValue("@productoId", productoId);
                                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                                cmdDetalle.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

                conn.Close();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.ShowDialog();
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btnCobrar.PerformClick();
                    break;

                case Keys.F2:
                    txtCodigoBarras.Focus();
                    txtCodigoBarras.Clear();
                    break;

                case Keys.F3:
                    btnProductos.PerformClick();
                    break;

                case Keys.F4:
                    btnReportes.PerformClick();
                    break;

                case Keys.Escape:
                    if (dgvVenta.Rows.Count > 0 && dgvVenta.Rows[0].Cells["ColCodigo"].Value != null)
                    {
                        DialogResult result = MessageBox.Show("¿Cancelar la venta actual?", "Confirmar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            dgvVenta.Rows.Clear();
                            lblTotal.Text = "Total: $0.00";
                            txtCodigoBarras.Clear();
                            txtCodigoBarras.Focus();
                        }
                    }
                    break;

                case Keys.Delete:
                    if (dgvVenta.SelectedRows.Count > 0 && dgvVenta.Rows[0].Cells["ColCodigo"].Value != null)
                    {
                        dgvVenta.Rows.Remove(dgvVenta.SelectedRows[0]);
                        ActualizarTotal();
                    }
                    break;
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReporteVentasForm reportesForm = new ReporteVentasForm();
            reportesForm.ShowDialog();
        }

        private void ReproducirSonido()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("beep.wav");
                player.Play();
            }
            catch
            {
                // Si no encuentra el archivo, usa el beep del sistema
                SystemSounds.Beep.Play();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigoBarras.Focus();
                txtCodigoBarras.SelectAll();
                e.SuppressKeyPress = true;
            }
        }

        private void HacerBackup()
        {
            try
            {
                string dbOriginal = "kiosco.db";
                string carpetaBackup = "backups";
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string archivoBackup = carpetaBackup + "\\kiosco_" + fecha + ".db";

                // Crear carpeta si no existe
                if (!System.IO.Directory.Exists(carpetaBackup))
                {
                    System.IO.Directory.CreateDirectory(carpetaBackup);
                }

                // Solo hacer backup si no existe ya uno hoy
                if (!System.IO.File.Exists(archivoBackup))
                {
                    System.IO.File.Copy(dbOriginal, archivoBackup, true);
                }

                // Borrar backups viejos (más de 7 días)
                string[] backupsViejos = System.IO.Directory.GetFiles(carpetaBackup, "kiosco_*.db");
                foreach (string backup in backupsViejos)
                {
                    if (System.IO.File.GetCreationTime(backup) < DateTime.Now.AddDays(-7))
                    {
                        System.IO.File.Delete(backup);
                    }
                }
            }
            catch
            {
                // Si falla el backup, no interrumpe el programa
            }
        }
    }
}