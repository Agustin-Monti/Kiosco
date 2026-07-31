using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace KioscoApp
{
    public partial class ProductosForm : MetroForm
    {
        string connectionString = "Data Source=kiosco.db;Version=3;";

        public ProductosForm()
        {
            InitializeComponent();
            dgvProductos.DataBindingComplete += dgvProductos_DataBindingComplete;
            CargarProductos();
        }

        private void CargarProductos()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Productos ORDER BY Descripcion";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProductos.DataSource = dt;

                // Ocultar la columna Id
                if (dgvProductos.Columns["Id"] != null)
                    dgvProductos.Columns["Id"].Visible = false;

                // Renombrar columnas
                dgvProductos.Columns["CodigoBarras"].HeaderText = "Código";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["PrecioCosto"].HeaderText = "Costo";
                dgvProductos.Columns["PrecioVenta"].HeaderText = "Venta";
                dgvProductos.Columns["Stock"].HeaderText = "Stock";

                conn.Close();
            }

            // Pintar fuera del using, después de asignar el DataSource
            PintarStockBajo();
        }

        private void PintarStockBajo()
        {
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;

                var valorStock = fila.Cells["Stock"].Value;

                if (valorStock != null && valorStock != DBNull.Value)
                {
                    int stock = 0;
                    int.TryParse(valorStock.ToString(), out stock);

                    if (stock < 5)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtCodigo.Text = fila.Cells["CodigoBarras"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                txtPrecioCosto.Text = fila.Cells["PrecioCosto"].Value.ToString();
                txtPrecioVenta.Text = fila.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Código y Descripción son obligatorios.");
                return;
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    INSERT INTO Productos (CodigoBarras, Descripcion, PrecioCosto, PrecioVenta, Stock)
                    VALUES (@codigo, @descripcion, @costo, @venta, @stock)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@costo", Convert.ToDecimal(string.IsNullOrWhiteSpace(txtPrecioCosto.Text) ? "0" : txtPrecioCosto.Text));
                cmd.Parameters.AddWithValue("@venta", Convert.ToDecimal(string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ? "0" : txtPrecioVenta.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(string.IsNullOrWhiteSpace(txtStock.Text) ? "0" : txtStock.Text));
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            CargarProductos();
            
            LimpiarCampos();
            MessageBox.Show("Producto agregado.");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto de la grilla.");
                return;
            }

            string codigoOriginal = dgvProductos.SelectedRows[0].Cells["CodigoBarras"].Value.ToString();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    UPDATE Productos 
                    SET CodigoBarras = @codigoNuevo, Descripcion = @descripcion, 
                        PrecioCosto = @costo, PrecioVenta = @venta, Stock = @stock
                    WHERE CodigoBarras = @codigoOriginal";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigoNuevo", txtCodigo.Text.Trim());
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@costo", Convert.ToDecimal(string.IsNullOrWhiteSpace(txtPrecioCosto.Text) ? "0" : txtPrecioCosto.Text));
                cmd.Parameters.AddWithValue("@venta", Convert.ToDecimal(string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ? "0" : txtPrecioVenta.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(string.IsNullOrWhiteSpace(txtStock.Text) ? "0" : txtStock.Text));
                cmd.Parameters.AddWithValue("@codigoOriginal", codigoOriginal);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            CargarProductos();
            LimpiarCampos();
            MessageBox.Show("Producto modificado.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un producto de la grilla.");
                return;
            }

            string codigo = dgvProductos.SelectedRows[0].Cells["CodigoBarras"].Value.ToString();

            DialogResult resultado = MessageBox.Show("¿Eliminar " + codigo + "?", "Confirmar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Productos WHERE CodigoBarras = @codigo";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                CargarProductos();
                
                LimpiarCampos();
                MessageBox.Show("Producto eliminado.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecioCosto.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
        }

        private void dgvProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;

                var valorStock = fila.Cells["Stock"].Value;

                if (valorStock != null && valorStock != DBNull.Value)
                {
                    int stock = Convert.ToInt32(valorStock);

                    if (stock < 5)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(200, 50, 50);
                        fila.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }


        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }
    }
}