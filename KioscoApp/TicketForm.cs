using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace KioscoApp
{
    public partial class TicketForm : MetroForm
    {
        public TicketForm(string tipoPago, decimal total, System.Data.DataTable productos)
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Text = "Ticket de Venta";
            this.Size = new System.Drawing.Size(420, 550);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Resizable = false;
            this.StartPosition = FormStartPosition.CenterParent;

            CrearTicket(tipoPago, total, productos);
        }

        private void CrearTicket(string tipoPago, decimal total, System.Data.DataTable productos)
        {
            // Panel que simula el papel del ticket
            Panel panelTicket = new Panel();
            panelTicket.BackColor = System.Drawing.Color.White;
            panelTicket.Location = new System.Drawing.Point(35, 30);
            panelTicket.Size = new System.Drawing.Size(330, 400);
            panelTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(panelTicket);

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = "K I O S C O";
            lblTitulo.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.Black;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(75, 20);
            panelTicket.Controls.Add(lblTitulo);

            // Línea
            Label lblLinea1 = new Label();
            lblLinea1.Text = "─────────────────────────";
            lblLinea1.Font = new System.Drawing.Font("Consolas", 8F);
            lblLinea1.ForeColor = System.Drawing.Color.Black;
            lblLinea1.AutoSize = true;
            lblLinea1.Location = new System.Drawing.Point(15, 50);
            panelTicket.Controls.Add(lblLinea1);

            // Fecha
            Label lblFecha = new Label();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yy HH:mm");
            lblFecha.Font = new System.Drawing.Font("Consolas", 9F);
            lblFecha.ForeColor = System.Drawing.Color.Black;
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(15, 70);
            panelTicket.Controls.Add(lblFecha);

            // Línea
            Label lblLinea2 = new Label();
            lblLinea2.Text = "─────────────────────────";
            lblLinea2.Font = new System.Drawing.Font("Consolas", 8F);
            lblLinea2.ForeColor = System.Drawing.Color.Black;
            lblLinea2.AutoSize = true;
            lblLinea2.Location = new System.Drawing.Point(15, 90);
            panelTicket.Controls.Add(lblLinea2);

            // Encabezado productos
            Label lblEncabezado = new Label();
            lblEncabezado.Text = "Cant  Descripción          Precio   Subt";
            lblEncabezado.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            lblEncabezado.ForeColor = System.Drawing.Color.Black;
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new System.Drawing.Point(15, 110);
            panelTicket.Controls.Add(lblEncabezado);

            // Línea finita
            Label lblLinea3 = new Label();
            lblLinea3.Text = "─────────────────────────";
            lblLinea3.Font = new System.Drawing.Font("Consolas", 8F);
            lblLinea3.ForeColor = System.Drawing.Color.Black;
            lblLinea3.AutoSize = true;
            lblLinea3.Location = new System.Drawing.Point(15, 125);
            panelTicket.Controls.Add(lblLinea3);

            // Productos reales
            int y = 145;
            foreach (System.Data.DataRow row in productos.Rows)
            {
                string cant = row["Cantidad"].ToString().PadLeft(3);
                string desc = row["Descripcion"].ToString().Length > 18
                    ? row["Descripcion"].ToString().Substring(0, 18)
                    : row["Descripcion"].ToString().PadRight(18);
                string precio = "$" + Convert.ToDecimal(row["PrecioUnitario"]).ToString("0.00").PadLeft(7);
                string subt = "$" + Convert.ToDecimal(row["Subtotal"]).ToString("0.00").PadLeft(7);

                Label lblProducto = new Label();
                lblProducto.Text = cant + " " + desc + " " + precio + " " + subt;
                lblProducto.Font = new System.Drawing.Font("Consolas", 8F);
                lblProducto.ForeColor = System.Drawing.Color.Black;
                lblProducto.AutoSize = true;
                lblProducto.Location = new System.Drawing.Point(15, y);
                panelTicket.Controls.Add(lblProducto);

                y += 18;
            }

            // Línea
            Label lblLinea4 = new Label();
            lblLinea4.Text = "─────────────────────────";
            lblLinea4.Font = new System.Drawing.Font("Consolas", 8F);
            lblLinea4.ForeColor = System.Drawing.Color.Black;
            lblLinea4.AutoSize = true;
            lblLinea4.Location = new System.Drawing.Point(15, y + 5);
            panelTicket.Controls.Add(lblLinea4);

            // Total
            Label lblTotal = new Label();
            lblTotal.Text = "TOTAL: $" + total.ToString("0.00");
            lblTotal.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            lblTotal.ForeColor = System.Drawing.Color.Black;
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(15, y + 25);
            panelTicket.Controls.Add(lblTotal);

            // Pago
            Label lblPago = new Label();
            lblPago.Text = "Pago: " + tipoPago;
            lblPago.Font = new System.Drawing.Font("Consolas", 9F);
            lblPago.ForeColor = System.Drawing.Color.Black;
            lblPago.AutoSize = true;
            lblPago.Location = new System.Drawing.Point(15, y + 55);
            panelTicket.Controls.Add(lblPago);

            // Línea
            Label lblLinea5 = new Label();
            lblLinea5.Text = "─────────────────────────";
            lblLinea5.Font = new System.Drawing.Font("Consolas", 8F);
            lblLinea5.ForeColor = System.Drawing.Color.Black;
            lblLinea5.AutoSize = true;
            lblLinea5.Location = new System.Drawing.Point(15, y + 75);
            panelTicket.Controls.Add(lblLinea5);

            // Gracias
            Label lblGracias = new Label();
            lblGracias.Text = "¡Gracias por su compra!";
            lblGracias.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            lblGracias.ForeColor = System.Drawing.Color.Black;
            lblGracias.AutoSize = true;
            lblGracias.Location = new System.Drawing.Point(30, y + 95);
            panelTicket.Controls.Add(lblGracias);

            // Botón cerrar
            MetroFramework.Controls.MetroButton btnCerrar = new MetroFramework.Controls.MetroButton();
            btnCerrar.Text = "CERRAR";
            btnCerrar.Size = new System.Drawing.Size(200, 40);
            btnCerrar.Location = new System.Drawing.Point(100, 450);
            btnCerrar.Style = MetroFramework.MetroColorStyle.Silver;
            btnCerrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnCerrar.Click += (s, ev) => this.Close();
            this.Controls.Add(btnCerrar);
        }
    }
}