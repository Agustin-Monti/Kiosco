using System;
using System.Data.SQLite;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace KioscoApp
{
    public partial class AgregarProductoNuevoForm : MetroForm
    {
        string connectionString = "Data Source=kiosco.db;Version=3;";
        string codigoBarras;

        public AgregarProductoNuevoForm(string codigo)
        {
            InitializeComponent();
            codigoBarras = codigo;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Text = "Agregar Producto Nuevo";
            this.Size = new System.Drawing.Size(450, 400);
            this.StartPosition = FormStartPosition.CenterParent;

            CrearControles();
        }

        private void CrearControles()
        {
            // Código
            MetroLabel lblCodigo = new MetroLabel();
            lblCodigo.Text = "Código de Barras:";
            lblCodigo.Location = new System.Drawing.Point(30, 60);
            lblCodigo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(lblCodigo);

            MetroLabel lblCodigoValor = new MetroLabel();
            lblCodigoValor.Text = codigoBarras;
            lblCodigoValor.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lblCodigoValor.Location = new System.Drawing.Point(160, 60);
            lblCodigoValor.Size = new System.Drawing.Size(250, 25);
            lblCodigoValor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(lblCodigoValor);

            // Descripción
            MetroLabel lblDesc = new MetroLabel();
            lblDesc.Text = "Descripción:";
            lblDesc.Location = new System.Drawing.Point(30, 100);
            lblDesc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(lblDesc);

            MetroTextBox txtDescripcion = new MetroTextBox();
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Location = new System.Drawing.Point(160, 95);
            txtDescripcion.Size = new System.Drawing.Size(250, 25);
            txtDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(txtDescripcion);

            // Precio Costo
            MetroLabel lblCosto = new MetroLabel();
            lblCosto.Text = "Precio Costo: $";
            lblCosto.Location = new System.Drawing.Point(30, 140);
            lblCosto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(lblCosto);

            MetroTextBox txtCosto = new MetroTextBox();
            txtCosto.Name = "txtCosto";
            txtCosto.Location = new System.Drawing.Point(160, 135);
            txtCosto.Size = new System.Drawing.Size(100, 25);
            txtCosto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(txtCosto);

            // Precio Venta
            MetroLabel lblVenta = new MetroLabel();
            lblVenta.Text = "Precio Venta: $";
            lblVenta.Location = new System.Drawing.Point(30, 180);
            lblVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(lblVenta);

            MetroTextBox txtVenta = new MetroTextBox();
            txtVenta.Name = "txtVenta";
            txtVenta.Location = new System.Drawing.Point(160, 175);
            txtVenta.Size = new System.Drawing.Size(100, 25);
            txtVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(txtVenta);

            // Stock
            MetroLabel lblStock = new MetroLabel();
            lblStock.Text = "Stock inicial:";
            lblStock.Location = new System.Drawing.Point(30, 220);
            lblStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(lblStock);

            MetroTextBox txtStock = new MetroTextBox();
            txtStock.Name = "txtStock";
            txtStock.Location = new System.Drawing.Point(160, 215);
            txtStock.Size = new System.Drawing.Size(100, 25);
            txtStock.Text = "0";
            txtStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(txtStock);

            // Botón Guardar
            MetroButton btnGuardar = new MetroButton();
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Size = new System.Drawing.Size(180, 45);
            btnGuardar.Location = new System.Drawing.Point(130, 280);
            btnGuardar.Style = MetroFramework.MetroColorStyle.Green;
            btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnGuardar.Click += (s, e) =>
            {
                string desc = txtDescripcion.Text.Trim();
                if (string.IsNullOrEmpty(desc))
                {
                    MessageBox.Show("La descripción es obligatoria.");
                    return;
                }

                decimal costo = 0;
                decimal.TryParse(txtCosto.Text, out costo);

                decimal venta = 0;
                decimal.TryParse(txtVenta.Text, out venta);

                int stock = 0;
                int.TryParse(txtStock.Text, out stock);

                GuardarProducto(codigoBarras, desc, costo, venta, stock);
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            this.Controls.Add(btnGuardar);
        }

        private void GuardarProducto(string codigo, string descripcion, decimal costo, decimal venta, int stock)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Productos (CodigoBarras, Descripcion, PrecioCosto, PrecioVenta, Stock)
                    VALUES (@codigo, @desc, @costo, @venta, @stock)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@desc", descripcion);
                cmd.Parameters.AddWithValue("@costo", costo);
                cmd.Parameters.AddWithValue("@venta", venta);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
