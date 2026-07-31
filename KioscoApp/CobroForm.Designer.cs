namespace KioscoApp
{
    partial class CobroForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTotalCobrar = new MetroFramework.Controls.MetroLabel();
            this.lblPago = new MetroFramework.Controls.MetroLabel();
            this.cmbTipoPago = new MetroFramework.Controls.MetroComboBox();
            this.lblMontoRecibido = new MetroFramework.Controls.MetroLabel();
            this.txtMontoRecibido = new MetroFramework.Controls.MetroTextBox();
            this.lblVuelto = new MetroFramework.Controls.MetroLabel();
            this.btnTicket = new MetroFramework.Controls.MetroButton();
            this.btnCobrar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblTotalCobrar
            // 
            this.lblTotalCobrar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalCobrar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalCobrar.Location = new System.Drawing.Point(23, 60);
            this.lblTotalCobrar.Name = "lblTotalCobrar";
            this.lblTotalCobrar.Size = new System.Drawing.Size(354, 50);
            this.lblTotalCobrar.TabIndex = 0;
            this.lblTotalCobrar.Text = "Total a cobrar: $0.00";
            this.lblTotalCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalCobrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPago.Location = new System.Drawing.Point(23, 130);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(87, 19);
            this.lblPago.TabIndex = 1;
            this.lblPago.Text = "Tipo de pago:";
            this.lblPago.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.ItemHeight = 23;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Débito",
            "Crédito",
            "Mercado Pago",
            "Transferencia"});
            this.cmbTipoPago.Location = new System.Drawing.Point(130, 125);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(247, 29);
            this.cmbTipoPago.TabIndex = 2;
            this.cmbTipoPago.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            // 
            // lblMontoRecibido
            // 
            this.lblMontoRecibido.AutoSize = true;
            this.lblMontoRecibido.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMontoRecibido.Location = new System.Drawing.Point(23, 175);
            this.lblMontoRecibido.Name = "lblMontoRecibido";
            this.lblMontoRecibido.Size = new System.Drawing.Size(107, 19);
            this.lblMontoRecibido.TabIndex = 3;
            this.lblMontoRecibido.Text = "Monto recibido:";
            this.lblMontoRecibido.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMontoRecibido.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtMontoRecibido.Location = new System.Drawing.Point(130, 165);
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new System.Drawing.Size(247, 35);
            this.txtMontoRecibido.TabIndex = 4;
            this.txtMontoRecibido.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtMontoRecibido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontoRecibido_KeyDown);
            // 
            // lblVuelto
            // 
            this.lblVuelto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVuelto.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVuelto.Location = new System.Drawing.Point(23, 215);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(354, 35);
            this.lblVuelto.TabIndex = 5;
            this.lblVuelto.Text = "Vuelto: $0.00";
            this.lblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVuelto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblVuelto.UseStyleColors = true;
            // 
            // btnTicket
            // 
            this.btnTicket.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTicket.Location = new System.Drawing.Point(23, 265);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(354, 40);
            this.btnTicket.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnTicket.TabIndex = 8;
            this.btnTicket.Text = "VER TICKET";
            this.btnTicket.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCobrar.FontWeight = MetroFramework.MetroButtonWeight.Bold;
            this.btnCobrar.Location = new System.Drawing.Point(23, 320);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(170, 50);
            this.btnCobrar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.Location = new System.Drawing.Point(207, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 50);
            this.btnCancelar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CobroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 395);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.lblMontoRecibido);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblTotalCobrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CobroForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cobrar";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTotalCobrar;
        private MetroFramework.Controls.MetroLabel lblPago;
        private MetroFramework.Controls.MetroComboBox cmbTipoPago;
        private MetroFramework.Controls.MetroLabel lblMontoRecibido;
        private MetroFramework.Controls.MetroTextBox txtMontoRecibido;
        private MetroFramework.Controls.MetroLabel lblVuelto;
        private MetroFramework.Controls.MetroButton btnTicket;
        private MetroFramework.Controls.MetroButton btnCobrar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}
