using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace DBMS_MenuManagement
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;

            DataTable revenueData = GetRevenueReport(start, end);
            dataGridRevenue.DataSource = revenueData;

            DisplayTotalRevenue(revenueData);

            DisplayRevenueChart(revenueData);
        }

        public DataTable GetRevenueReport(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Fast_Food_DB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("GetRevenueReportByDateRange", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerEnd.Value = DateTime.Now;

            DataTable revenueData = GetRevenueReport(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            dataGridRevenue.DataSource = revenueData;
        }


        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dataGridRevenue.DataSource == null || dataGridRevenue.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[1];
            xlWorkSheet.Name = "Revenue Data";

            for (int i = 0; i < dataGridRevenue.Columns.Count; i++)
            {
                xlWorkSheet.Cells[1, i + 1] = dataGridRevenue.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridRevenue.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridRevenue.Columns.Count; j++)
                {
                    var cellValue = dataGridRevenue.Rows[i].Cells[j].Value;

                    if (cellValue != null)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = cellValue.ToString();
                    }
                    else
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = "";
                    }

                    if (j == 2 || j == 3)
                    {
                        ((Excel.Range)xlWorkSheet.Cells[i + 2, j + 1]).NumberFormat = "#,##0.00";
                    }
                }
            }

            xlWorkSheet.Columns.AutoFit();


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Excel file saved successfully.");
            }
        }

        private void DisplayRevenueChart(DataTable revenueData)
        {
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartRevenue.ChartAreas.Add(chartArea);

            Series series = new Series("Revenue");
            series.ChartType = SeriesChartType.Line;
            chartRevenue.Series.Add(series);

            foreach (DataRow row in revenueData.Rows)
            {
                DateTime date = Convert.ToDateTime(row["RevenueDate"]);
                decimal totalAmount = Convert.ToDecimal(row["TotalAmount"]);

                series.Points.AddXY(date, totalAmount);
            }

            chartRevenue.Invalidate();
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            DataTable revenueData = GetRevenueReport(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            DisplayRevenueChart(revenueData);
        }
        private void DisplayTotalRevenue(DataTable revenueData)
        {
            decimal totalRevenue = 0;

            // Tính tổng doanh thu
            foreach (DataRow row in revenueData.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["TotalAmount"]);
            }

            // Hiển thị tổng doanh thu
            lblTotalRevenue.Text = "Total Revenue: " + totalRevenue.ToString("C");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
