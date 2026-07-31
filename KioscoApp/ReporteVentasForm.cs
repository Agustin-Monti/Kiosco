using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace KioscoApp
{
    public partial class ReporteVentasForm : MetroForm
    {
        string connectionString = "Data Source=kiosco.db;Version=3;";

        public ReporteVentasForm()
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Text = "Reporte de Ventas";
            this.Size = new System.Drawing.Size(750, 600);

            CargarReporte();
        }

        private void CargarReporte()
        {
            // Panel izquierdo - filtros
            Panel panelFiltros = new Panel();
            panelFiltros.Location = new System.Drawing.Point(20, 60);
            panelFiltros.Size = new System.Drawing.Size(200, 500);
            this.Controls.Add(panelFiltros);

            // Filtro: Hoy
            MetroButton btnHoy = new MetroButton();
            btnHoy.Text = "HOY";
            btnHoy.Location = new System.Drawing.Point(10, 20);
            btnHoy.Size = new System.Drawing.Size(180, 40);
            btnHoy.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnHoy.Click += (s, e) => MostrarVentas("hoy");
            panelFiltros.Controls.Add(btnHoy);

            // Filtro: Esta semana
            MetroButton btnSemana = new MetroButton();
            btnSemana.Text = "ESTA SEMANA";
            btnSemana.Location = new System.Drawing.Point(10, 70);
            btnSemana.Size = new System.Drawing.Size(180, 40);
            btnSemana.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnSemana.Click += (s, e) => MostrarVentas("semana");
            panelFiltros.Controls.Add(btnSemana);

            // Filtro: Este mes
            MetroButton btnMes = new MetroButton();
            btnMes.Text = "ESTE MES";
            btnMes.Location = new System.Drawing.Point(10, 120);
            btnMes.Size = new System.Drawing.Size(180, 40);
            btnMes.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnMes.Click += (s, e) => MostrarVentas("mes");
            panelFiltros.Controls.Add(btnMes);

            // Filtro: Más vendidos
            MetroButton btnMasVendidos = new MetroButton();
            btnMasVendidos.Text = "MÁS VENDIDOS";
            btnMasVendidos.Location = new System.Drawing.Point(10, 200);
            btnMasVendidos.Size = new System.Drawing.Size(180, 40);
            btnMasVendidos.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnMasVendidos.Style = MetroFramework.MetroColorStyle.Orange;
            btnMasVendidos.Click += (s, e) => MostrarMasVendidos();
            panelFiltros.Controls.Add(btnMasVendidos);

            // Filtro: Ventas por día
            MetroButton btnVentasPorDia = new MetroButton();
            btnVentasPorDia.Text = "VENTAS POR DÍA";
            btnVentasPorDia.Location = new System.Drawing.Point(10, 250);
            btnVentasPorDia.Size = new System.Drawing.Size(180, 40);
            btnVentasPorDia.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnVentasPorDia.Click += (s, e) => MostrarVentasPorDia();
            panelFiltros.Controls.Add(btnVentasPorDia);

            // Botón Exportar a Excel
            MetroButton btnExportar = new MetroButton();
            btnExportar.Text = "EXPORTAR EXCEL";
            btnExportar.Location = new System.Drawing.Point(10, 320);
            btnExportar.Size = new System.Drawing.Size(180, 40);
            btnExportar.Theme = MetroFramework.MetroThemeStyle.Dark;
            btnExportar.Style = MetroFramework.MetroColorStyle.Green;
            btnExportar.Click += (s, e) => ExportarAExcel();
            panelFiltros.Controls.Add(btnExportar);

            // Grilla derecha
            MetroGrid dgvReporte = new MetroGrid();
            dgvReporte.Name = "dgvReporte";
            dgvReporte.Location = new System.Drawing.Point(240, 60);
            dgvReporte.Size = new System.Drawing.Size(480, 480);
            dgvReporte.Theme = MetroFramework.MetroThemeStyle.Dark;
            dgvReporte.BackgroundColor = Color.FromArgb(17, 17, 17);
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgvReporte);

            // Label de total
            MetroLabel lblTotalReporte = new MetroLabel();
            lblTotalReporte.Name = "lblTotalReporte";
            lblTotalReporte.Location = new System.Drawing.Point(240, 20);
            lblTotalReporte.Size = new System.Drawing.Size(480, 30);
            lblTotalReporte.FontSize = MetroLabelSize.Tall;
            lblTotalReporte.FontWeight = MetroLabelWeight.Bold;
            lblTotalReporte.Theme = MetroFramework.MetroThemeStyle.Dark;
            lblTotalReporte.Text = "Seleccioná un filtro para ver las ventas";
            this.Controls.Add(lblTotalReporte);

            // Mostrar ventas de hoy por defecto
            MostrarVentas("hoy");
        }

        private void MostrarVentas(string filtro)
        {
            string where = "";
            string titulo = "";

            switch (filtro)
            {
                case "hoy":
                    where = "WHERE date(Fecha) = date('now', 'localtime')";
                    titulo = "Ventas de Hoy";
                    break;
                case "semana":
                    where = "WHERE date(Fecha) >= date('now', '-7 days', 'localtime')";
                    titulo = "Ventas de esta Semana";
                    break;
                case "mes":
                    where = "WHERE strftime('%Y-%m', Fecha) = strftime('%Y-%m', 'now', 'localtime')";
                    titulo = "Ventas de este Mes";
                    break;
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Total
                string sqlTotal = "SELECT COALESCE(SUM(Total), 0) FROM Ventas " + where;
                SQLiteCommand cmdTotal = new SQLiteCommand(sqlTotal, conn);
                decimal total = Convert.ToDecimal(cmdTotal.ExecuteScalar());

                // Cantidad de ventas
                string sqlCantidad = "SELECT COUNT(*) FROM Ventas " + where;
                SQLiteCommand cmdCantidad = new SQLiteCommand(sqlCantidad, conn);
                int cantidad = Convert.ToInt32(cmdCantidad.ExecuteScalar());

                // Desglose por tipo de pago
                string sqlPagos = @"
                    SELECT TipoPago, COUNT(*) as Cantidad, SUM(Total) as Total 
                    FROM Ventas " + where + @" 
                    GROUP BY TipoPago 
                    ORDER BY Total DESC";
                SQLiteCommand cmdPagos = new SQLiteCommand(sqlPagos, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmdPagos);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Actualizar label
                var lblTotal = this.Controls.Find("lblTotalReporte", true)[0] as MetroLabel;
                lblTotal.Text = titulo + " | " + cantidad + " ventas | Total: $" + total.ToString("0.00");

                // Actualizar grilla
                var dgv = this.Controls.Find("dgvReporte", true)[0] as MetroGrid;
                dgv.DataSource = dt;
                dgv.Columns["TipoPago"].HeaderText = "Tipo de Pago";
                dgv.Columns["Cantidad"].HeaderText = "Cantidad";
                dgv.Columns["Total"].HeaderText = "Total";
                dgv.Columns["Total"].DefaultCellStyle.Format = "$#,##0.00";

                conn.Close();
            }
        }

        private void MostrarMasVendidos()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT p.Descripcion as Producto, 
                           SUM(dv.Cantidad) as 'Unidades Vendidas',
                           SUM(dv.Cantidad * dv.PrecioUnitario) as 'Total Vendido'
                    FROM DetalleVenta dv
                    JOIN Productos p ON dv.ProductoId = p.Id
                    GROUP BY p.Descripcion
                    ORDER BY SUM(dv.Cantidad) DESC
                    LIMIT 20";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                var lblTotal = this.Controls.Find("lblTotalReporte", true)[0] as MetroLabel;
                lblTotal.Text = "Productos Más Vendidos";

                var dgv = this.Controls.Find("dgvReporte", true)[0] as MetroGrid;
                dgv.DataSource = dt;
                dgv.Columns["Total Vendido"].DefaultCellStyle.Format = "$#,##0.00";

                conn.Close();
            }
        }

        private void MostrarVentasPorDia()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT date(Fecha) as Día,
                           COUNT(*) as Ventas,
                           SUM(Total) as Total
                    FROM Ventas
                    GROUP BY date(Fecha)
                    ORDER BY date(Fecha) DESC
                    LIMIT 30";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                var lblTotal = this.Controls.Find("lblTotalReporte", true)[0] as MetroLabel;
                lblTotal.Text = "Ventas por Día (últimos 30 días)";

                var dgv = this.Controls.Find("dgvReporte", true)[0] as MetroGrid;
                dgv.DataSource = dt;
                dgv.Columns["Total"].DefaultCellStyle.Format = "$#,##0.00";

                conn.Close();
            }
        }

        private void ExportarAExcel()
        {
            try
            {
                var dgv = this.Controls.Find("dgvReporte", true)[0] as DataGridView;
                var lbl = this.Controls.Find("lblTotalReporte", true)[0] as MetroLabel;

                if (dgv == null || dgv.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.");
                    return;
                }

                // Crear archivo Excel
                var workbook = new ClosedXML.Excel.XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Ventas");

                // Título
                worksheet.Cell(1, 1).Value = lbl.Text;
                worksheet.Cell(1, 1).Style.Font.Bold = true;
                worksheet.Range(1, 1, 1, dgv.Columns.Count).Merge();

                // Encabezados
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cell(3, i + 1).Value = dgv.Columns[i].HeaderText;
                    worksheet.Cell(3, i + 1).Style.Font.Bold = true;
                }

                // Datos
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].IsNewRow) continue;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 4, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                // Ajustar columnas
                worksheet.Columns().AdjustToContents();

                // Guardar
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel (*.xlsx)|*.xlsx";
                saveDialog.FileName = "Ventas_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Exportado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }
    }
}