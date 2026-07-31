namespace KioscoApp
{
    partial class ProductosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioVenta = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioCosto = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioVenta = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioCosto = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProductos.Location = new System.Drawing.Point(23, 63);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(654, 260);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.btnEliminar);
            this.grpDatos.Controls.Add(this.btnModificar);
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Controls.Add(this.txtStock);
            this.grpDatos.Controls.Add(this.txtPrecioVenta);
            this.grpDatos.Controls.Add(this.txtPrecioCosto);
            this.grpDatos.Controls.Add(this.txtDescripcion);
            this.grpDatos.Controls.Add(this.txtCodigo);
            this.grpDatos.Controls.Add(this.lblStock);
            this.grpDatos.Controls.Add(this.lblPrecioVenta);
            this.grpDatos.Controls.Add(this.lblPrecioCosto);
            this.grpDatos.Controls.Add(this.lblDescripcion);
            this.grpDatos.Controls.Add(this.lblCodigo);
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.ForeColor = System.Drawing.Color.White;
            this.grpDatos.Location = new System.Drawing.Point(23, 340);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(654, 180);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Producto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(530, 130);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(370, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 35);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(210, 130);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 35);
            this.btnModificar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(50, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 35);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtStock
            // 
            // 
            // 
            // 
            this.txtStock.CustomButton.Image = null;
            this.txtStock.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtStock.CustomButton.Name = "";
            this.txtStock.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock.CustomButton.TabIndex = 1;
            this.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock.CustomButton.UseSelectable = true;
            this.txtStock.CustomButton.Visible = false;
            this.txtStock.Lines = new string[0];
            this.txtStock.Location = new System.Drawing.Point(554, 50);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.ShortcutsEnabled = true;
            this.txtStock.Size = new System.Drawing.Size(76, 25);
            this.txtStock.TabIndex = 9;
            this.txtStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtStock.UseSelectable = true;
            this.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrecioVenta
            // 
            // 
            // 
            // 
            this.txtPrecioVenta.CustomButton.Image = null;
            this.txtPrecioVenta.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.txtPrecioVenta.CustomButton.Name = "";
            this.txtPrecioVenta.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPrecioVenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioVenta.CustomButton.TabIndex = 1;
            this.txtPrecioVenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioVenta.CustomButton.UseSelectable = true;
            this.txtPrecioVenta.CustomButton.Visible = false;
            this.txtPrecioVenta.Lines = new string[0];
            this.txtPrecioVenta.Location = new System.Drawing.Point(415, 50);
            this.txtPrecioVenta.MaxLength = 32767;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.ShortcutsEnabled = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(73, 25);
            this.txtPrecioVenta.TabIndex = 8;
            this.txtPrecioVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrecioVenta.UseSelectable = true;
            this.txtPrecioVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrecioCosto
            // 
            // 
            // 
            // 
            this.txtPrecioCosto.CustomButton.Image = null;
            this.txtPrecioCosto.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.txtPrecioCosto.CustomButton.Name = "";
            this.txtPrecioCosto.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPrecioCosto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioCosto.CustomButton.TabIndex = 1;
            this.txtPrecioCosto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioCosto.CustomButton.UseSelectable = true;
            this.txtPrecioCosto.CustomButton.Visible = false;
            this.txtPrecioCosto.Lines = new string[0];
            this.txtPrecioCosto.Location = new System.Drawing.Point(283, 50);
            this.txtPrecioCosto.MaxLength = 32767;
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.PasswordChar = '\0';
            this.txtPrecioCosto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioCosto.SelectedText = "";
            this.txtPrecioCosto.SelectionLength = 0;
            this.txtPrecioCosto.SelectionStart = 0;
            this.txtPrecioCosto.ShortcutsEnabled = true;
            this.txtPrecioCosto.Size = new System.Drawing.Size(67, 25);
            this.txtPrecioCosto.TabIndex = 7;
            this.txtPrecioCosto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrecioCosto.UseSelectable = true;
            this.txtPrecioCosto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioCosto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(506, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(100, 85);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(530, 25);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(100, 50);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(123, 25);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStock.Location = new System.Drawing.Point(503, 50);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 19);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            this.lblStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPrecioVenta.Location = new System.Drawing.Point(362, 50);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(47, 19);
            this.lblPrecioVenta.TabIndex = 3;
            this.lblPrecioVenta.Text = "Venta:";
            this.lblPrecioVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPrecioCosto.Location = new System.Drawing.Point(229, 50);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(48, 19);
            this.lblPrecioCosto.TabIndex = 2;
            this.lblPrecioCosto.Text = "Costo:";
            this.lblPrecioCosto.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 19);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCodigo.Location = new System.Drawing.Point(10, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Cód. Barras:";
            this.lblCodigo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductosForm";
            this.Text = "Gestión de Productos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvProductos;
        private System.Windows.Forms.GroupBox grpDatos;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroTextBox txtPrecioVenta;
        private MetroFramework.Controls.MetroTextBox txtPrecioCosto;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblPrecioVenta;
        private MetroFramework.Controls.MetroLabel lblPrecioCosto;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel lblCodigo;
    }
}