namespace KioscoApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigoBarras = new MetroFramework.Controls.MetroTextBox();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.btnCobrar = new MetroFramework.Controls.MetroButton();
            this.dgvVenta = new MetroFramework.Controls.MetroGrid();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCamara = new MetroFramework.Controls.MetroComboBox();
            this.pictureBoxCamara = new System.Windows.Forms.PictureBox();
            this.timerCamara = new System.Windows.Forms.Timer(this.components);
            this.btnProductos = new MetroFramework.Controls.MetroButton();
            this.btnReportes = new MetroFramework.Controls.MetroButton();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCantidad.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCantidad.Lines = new string[] {
        "1"};
            this.txtCantidad.Location = new System.Drawing.Point(23, 440);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(55, 40);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // txtCodigoBarras
            // 
            // 
            // 
            // 
            this.txtCodigoBarras.CustomButton.Image = null;
            this.txtCodigoBarras.CustomButton.Location = new System.Drawing.Point(401, 2);
            this.txtCodigoBarras.CustomButton.Name = "";
            this.txtCodigoBarras.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtCodigoBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoBarras.CustomButton.TabIndex = 1;
            this.txtCodigoBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoBarras.CustomButton.UseSelectable = true;
            this.txtCodigoBarras.CustomButton.Visible = false;
            this.txtCodigoBarras.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCodigoBarras.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCodigoBarras.Lines = new string[0];
            this.txtCodigoBarras.Location = new System.Drawing.Point(84, 440);
            this.txtCodigoBarras.MaxLength = 32767;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.PasswordChar = '\0';
            this.txtCodigoBarras.PromptText = "Escanear o escribir código de barras...";
            this.txtCodigoBarras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoBarras.SelectedText = "";
            this.txtCodigoBarras.SelectionLength = 0;
            this.txtCodigoBarras.SelectionStart = 0;
            this.txtCodigoBarras.ShortcutsEnabled = true;
            this.txtCodigoBarras.Size = new System.Drawing.Size(439, 40);
            this.txtCodigoBarras.TabIndex = 0;
            this.txtCodigoBarras.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCodigoBarras.UseSelectable = true;
            this.txtCodigoBarras.WaterMark = "Escanear o escribir código de barras...";
            this.txtCodigoBarras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoBarras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotal.Location = new System.Drawing.Point(540, 440);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(240, 40);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTotal.UseStyleColors = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCobrar.Location = new System.Drawing.Point(540, 500);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(240, 55);
            this.btnCobrar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "COBRAR (F5)";
            this.btnCobrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCobrar.UseSelectable = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AllowUserToResizeRows = false;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVenta.ColumnHeadersHeight = 35;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColCantidad,
            this.ColPrecio,
            this.ColSubtotal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvVenta.Location = new System.Drawing.Point(190, 80);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVenta.RowTemplate.Height = 30;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(590, 340);
            this.dgvVenta.TabIndex = 3;
            this.dgvVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCantidad.HeaderText = "Cant";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 54;
            // 
            // ColPrecio
            // 
            this.ColPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPrecio.HeaderText = "Precio Unit";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 79;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.ReadOnly = true;
            this.ColSubtotal.Width = 74;
            // 
            // cmbCamara
            // 
            this.cmbCamara.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.ItemHeight = 19;
            this.cmbCamara.Location = new System.Drawing.Point(23, 80);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(150, 25);
            this.cmbCamara.TabIndex = 4;
            this.cmbCamara.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbCamara.UseSelectable = true;
            this.cmbCamara.SelectedIndexChanged += new System.EventHandler(this.cmbCamara_SelectedIndexChanged);
            // 
            // pictureBoxCamara
            // 
            this.pictureBoxCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamara.Location = new System.Drawing.Point(23, 115);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamara.TabIndex = 5;
            this.pictureBoxCamara.TabStop = false;
            // 
            // timerCamara
            // 
            this.timerCamara.Tick += new System.EventHandler(this.timerCamara_Tick);
            // 
            // btnProductos
            // 
            this.btnProductos.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnProductos.Location = new System.Drawing.Point(23, 500);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(120, 55);
            this.btnProductos.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Productos";
            this.btnProductos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProductos.UseSelectable = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnReportes.Location = new System.Drawing.Point(150, 500);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(120, 55);
            this.btnReportes.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReportes.UseSelectable = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitulo.Location = new System.Drawing.Point(190, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "VENTA EN CURSO";
            this.lblTitulo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.pictureBoxCamara);
            this.Controls.Add(this.cmbCamara);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCodigoBarras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kiosco - Venta";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroTextBox txtCodigoBarras;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroButton btnCobrar;
        private MetroFramework.Controls.MetroGrid dgvVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private MetroFramework.Controls.MetroComboBox cmbCamara;
        private System.Windows.Forms.PictureBox pictureBoxCamara;
        private System.Windows.Forms.Timer timerCamara;
        private MetroFramework.Controls.MetroButton btnProductos;
        private MetroFramework.Controls.MetroButton btnReportes;
        private MetroFramework.Controls.MetroLabel lblTitulo;
    }
}