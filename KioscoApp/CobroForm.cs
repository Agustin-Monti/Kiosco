using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace KioscoApp
{
    public partial class CobroForm : MetroForm
    {
        public decimal Total { get; set; }
        public string TipoPago { get; private set; }
        public bool CobroExitoso { get; private set; }
        public System.Data.DataTable ProductosVenta { get; set; }

        public CobroForm(decimal total)
        {
            InitializeComponent();
            Total = total;
            lblTotalCobrar.Text = "Total a cobrar: $" + total.ToString("0.00");
            cmbTipoPago.SelectedIndex = 0;
            ActualizarVista();
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            if (cmbTipoPago.SelectedItem == null) return;

            bool esEfectivo = cmbTipoPago.SelectedItem.ToString() == "Efectivo";

            lblMontoRecibido.Visible = esEfectivo;
            txtMontoRecibido.Visible = esEfectivo;
            lblVuelto.Visible = esEfectivo;

            if (!esEfectivo)
            {
                lblVuelto.Text = "";
                txtMontoRecibido.Clear();
            }
        }

        private void txtMontoRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularVuelto();
                e.SuppressKeyPress = true;

                // Si el monto está bien, cobrar directo con Enter
                decimal monto;
                if (decimal.TryParse(txtMontoRecibido.Text, out monto) && monto >= Total)
                {
                    btnCobrar.PerformClick();
                }
            }
        }

        private void CalcularVuelto()
        {
            decimal montoRecibido;
            if (decimal.TryParse(txtMontoRecibido.Text, out montoRecibido))
            {
                if (montoRecibido >= Total)
                {
                    lblVuelto.Text = "Vuelto: $" + (montoRecibido - Total).ToString("0.00");
                }
                else
                {
                    lblVuelto.Text = "Falta: $" + (Total - montoRecibido).ToString("0.00");
                }
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm(cmbTipoPago.SelectedItem.ToString(), Total, ProductosVenta);
            ticketForm.ShowDialog();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (cmbTipoPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un tipo de pago.");
                return;
            }

            TipoPago = cmbTipoPago.SelectedItem.ToString();

            if (TipoPago == "Efectivo")
            {
                decimal montoRecibido;
                if (!decimal.TryParse(txtMontoRecibido.Text, out montoRecibido))
                {
                    MessageBox.Show("Ingresá un monto válido.");
                    return;
                }
                if (montoRecibido < Total)
                {
                    MessageBox.Show("El monto recibido es menor al total.");
                    return;
                }
            }

            CobroExitoso = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CobroExitoso = false;
            this.Close();
        }
    }
}