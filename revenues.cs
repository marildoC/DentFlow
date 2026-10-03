using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace DENTAL
{
    public partial class revenues : UserControl
    {
        private string connectionString =
           @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        private Chart chartRevenue;
        private Button btnLastMonth;
        private Button btnThisMonth;
        private Button btnYear;
        private Panel topPanel;
        private Label titleLabel;

        public revenues()
        {
            InitializeAllControls();
        }

        
        private void InitializeAllControls()
        {
            this.Size = new Size(900, 550);
            this.BackColor = Color.White;

            topPanel = new Panel();
            topPanel.Size = new Size(this.Width, 40);
            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = Color.DarkSlateGray;

            titleLabel = new Label();
            titleLabel.Text = "Revenue Overview";
            titleLabel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.AutoSize = false;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            topPanel.Controls.Add(titleLabel);

            chartRevenue = new Chart();
            chartRevenue.Name = "chartRevenue";
            chartRevenue.Dock = DockStyle.Fill;
            chartRevenue.BackColor = Color.WhiteSmoke;
            chartRevenue.BorderlineDashStyle = ChartDashStyle.Solid;
            chartRevenue.BorderlineColor = Color.DarkGray;
            chartRevenue.BorderlineWidth = 2;

            var area = new ChartArea("RevenueArea");
            area.AxisX.Title = "Time";
            area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            area.AxisY.Title = "Amount";
            area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            area.BackColor = Color.White;
            chartRevenue.ChartAreas.Add(area);

            var series = new Series("RevenueSeries");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.Color = Color.FromArgb(180, 0, 128, 128);
            series.BorderWidth = 2;
            series.IsValueShownAsLabel = true;
            chartRevenue.Series.Add(series);

            var legend = new Legend("MainLegend");
            legend.Docking = Docking.Right;
            chartRevenue.Legends.Add(legend);
            series.Legend = "MainLegend";
            series.LegendText = "Revenue ($)";

            var chartTitle = new Title();
            chartTitle.Name = "RevenueTitle";
            chartTitle.Text = "Monthly/Yearly Revenue";
            chartTitle.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            chartRevenue.Titles.Add(chartTitle);

            var bottomPanel = new Panel();
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = 50;
            bottomPanel.BackColor = Color.White;

            btnLastMonth = new Button();
            btnLastMonth.Text = "LastMonth";
            btnLastMonth.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnLastMonth.Size = new Size(90, 30);
            btnLastMonth.Location = new Point(10, 10);
            btnLastMonth.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btnLastMonth.BackColor = Color.Gainsboro;
            btnLastMonth.Click += (s, e) => { LoadLastMonthData(); };

            btnThisMonth = new Button();
            btnThisMonth.Text = "ThisMonth";
            btnThisMonth.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnThisMonth.Size = new Size(90, 30);
            btnThisMonth.Location = new Point(110, 10);
            btnThisMonth.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            btnThisMonth.BackColor = Color.Gainsboro;
            btnThisMonth.Click += (s, e) => { LoadThisMonthData(); };

            btnYear = new Button();
            btnYear.Text = "Year";
            btnYear.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnYear.Size = new Size(80, 30);
            btnYear.Location = new Point(bottomPanel.Width - 100, 10);
            btnYear.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            btnYear.BackColor = Color.Gainsboro;
            btnYear.Click += (s, e) => { LoadYearData(); };

            bottomPanel.Controls.Add(btnLastMonth);
            bottomPanel.Controls.Add(btnThisMonth);
            bottomPanel.Controls.Add(btnYear);

            this.Controls.Add(chartRevenue);
            this.Controls.Add(bottomPanel);
            this.Controls.Add(topPanel);

            this.Load += revenues_Load;
        }

        private void revenues_Load(object sender, EventArgs e)
        {
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadThisMonthData();
            }
        }

        
        private void LoadThisMonthData()
        {
            DateTime now = DateTime.Today;
            int year = now.Year;
            int month = now.Month;

            DateTime startOfMonth = new DateTime(year, month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            chartRevenue.Series["RevenueSeries"].Points.Clear();
            ConfigureYAxisForMonths();

            DateTime day10 = startOfMonth.AddDays(9);
            DateTime day20 = startOfMonth.AddDays(19);

            Console.WriteLine("==== THIS MONTH DEBUG ====");
            decimal sum1 = SumRevenueInRange(startOfMonth, day10);           
            decimal sum2 = SumRevenueInRange(day10.AddDays(1), day20);       
            decimal sum3 = SumRevenueInRange(day20.AddDays(1), endOfMonth);   

            int lastDay = endOfMonth.Day;
            string label1 = $"{MonthName(month)} (1-10)";
            string label2 = $"{MonthName(month)} (11-20)";
            string label3 = $"{MonthName(month)} (21-{lastDay})";

            bool allZero = (sum1 == 0 && sum2 == 0 && sum3 == 0);
            if (allZero)
            {
                chartRevenue.Series["RevenueSeries"].Points.AddXY("No data", 0);
            }
            else
            {
                AddPointWithPossibleZeroHiding(label1, sum1);
                AddPointWithPossibleZeroHiding(label2, sum2);
                AddPointWithPossibleZeroHiding(label3, sum3);
            }

            chartRevenue.Titles["RevenueTitle"].Text = "Revenue (This Month)";
        }

        
        private void LoadLastMonthData()
        {
            DateTime now = DateTime.Today;
            DateTime lastMonthDate = now.AddMonths(-1);

            int year = lastMonthDate.Year;
            int month = lastMonthDate.Month;

            DateTime startOfMonth = new DateTime(year, month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            chartRevenue.Series["RevenueSeries"].Points.Clear();
            ConfigureYAxisForMonths();

            DateTime day10 = startOfMonth.AddDays(9);
            DateTime day20 = startOfMonth.AddDays(19);

            Console.WriteLine("==== LAST MONTH DEBUG ====");
            decimal sum1 = SumRevenueInRange(startOfMonth, day10);
            decimal sum2 = SumRevenueInRange(day10.AddDays(1), day20);
            decimal sum3 = SumRevenueInRange(day20.AddDays(1), endOfMonth);

            int lastDay = endOfMonth.Day;
            string label1 = $"{MonthName(month)} (1-10)";
            string label2 = $"{MonthName(month)} (11-20)";
            string label3 = $"{MonthName(month)} (21-{lastDay})";

            bool allZero = (sum1 == 0 && sum2 == 0 && sum3 == 0);
            if (allZero)
            {
                chartRevenue.Series["RevenueSeries"].Points.AddXY("No data", 0);
            }
            else
            {
                AddPointWithPossibleZeroHiding(label1, sum1);
                AddPointWithPossibleZeroHiding(label2, sum2);
                AddPointWithPossibleZeroHiding(label3, sum3);
            }

            chartRevenue.Titles["RevenueTitle"].Text = "Revenue (Last Month)";
        }

        
        private void LoadYearData()
        {
            DateTime now = DateTime.Today;
            int year = now.Year;
            int currentMonth = now.Month;

            chartRevenue.Series["RevenueSeries"].Points.Clear();
            ConfigureYAxisForYear();

            Console.WriteLine("==== YEAR DEBUG ====");
            for (int m = 1; m <= currentMonth; m++)
            {
                DateTime start = new DateTime(year, m, 1);
                DateTime end = start.AddMonths(1).AddDays(-1);

                decimal sum = SumRevenueInRange(start, end);
                string label = MonthName(m);

                int ptIndex = chartRevenue.Series["RevenueSeries"].Points.AddXY(label, sum);
                if (sum == 0)
                {
                    chartRevenue.Series["RevenueSeries"].Points[ptIndex].IsValueShownAsLabel = false;
                }
            }

            bool allZero = true;
            foreach (var pt in chartRevenue.Series["RevenueSeries"].Points)
            {
                if (pt.YValues[0] != 0)
                {
                    allZero = false;
                    break;
                }
            }
            if (allZero)
            {
                chartRevenue.Series["RevenueSeries"].Points.Clear();
                chartRevenue.Series["RevenueSeries"].Points.AddXY("No data", 0);
            }

            chartRevenue.Titles["RevenueTitle"].Text = $"Revenue (Year {year})";
        }

       
        private decimal SumRevenueInRange(DateTime start, DateTime end)
        {
            Console.WriteLine($"DEBUG: Summing from {start:yyyy-MM-dd} to {end:yyyy-MM-dd}");

            decimal total = 0m;
            string sql = @"
                SELECT RevenueDate, Amount
                FROM RevenueRecords
                WHERE RevenueDate >= @start
                  AND RevenueDate <= @end
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            DateTime d = rdr.GetDateTime(0);
                            decimal amt = rdr.GetDecimal(1);
                            Console.WriteLine($"  Found row: {d:yyyy-MM-dd}, Amount={amt}");
                            total += amt;
                        }
                    }
                }
            }
            return total;
        }

        private void AddPointWithPossibleZeroHiding(string label, decimal sum)
        {
            int idx = chartRevenue.Series["RevenueSeries"].Points.AddXY(label, sum);
            if (sum == 0)
            {
                chartRevenue.Series["RevenueSeries"].Points[idx].IsValueShownAsLabel = false;
            }
        }

        
        private string MonthName(int m)
        {
            switch (m)
            {
                case 1: return "Jan";
                case 2: return "Feb";
                case 3: return "Mar";
                case 4: return "Apr";
                case 5: return "May";
                case 6: return "Jun";
                case 7: return "Jul";
                case 8: return "Aug";
                case 9: return "Sep";
                case 10: return "Oct";
                case 11: return "Nov";
                case 12: return "Dec";
                default: return "?";
            }
        }

        
        private void ConfigureYAxisForMonths()
        {
            var axisY = chartRevenue.ChartAreas["RevenueArea"].AxisY;
            axisY.CustomLabels.Clear();
            axisY.Minimum = 0;
            axisY.Maximum = 100000;
            axisY.Interval = 10000;

            AddCustomLabel(axisY, 1000);
            AddCustomLabel(axisY, 5000);
            AddCustomLabel(axisY, 10000);
            AddCustomLabel(axisY, 30000);
            AddCustomLabel(axisY, 50000);
            AddCustomLabel(axisY, 70000);
            AddCustomLabel(axisY, 100000);
        }

        
        private void ConfigureYAxisForYear()
        {
            var axisY = chartRevenue.ChartAreas["RevenueArea"].AxisY;
            axisY.CustomLabels.Clear();
            axisY.Minimum = 0;
            axisY.Maximum = 200000;
            axisY.Interval = 20000;

            AddCustomLabel(axisY, 5000);
            AddCustomLabel(axisY, 10000);
            AddCustomLabel(axisY, 20000); 
            AddCustomLabel(axisY, 40000); 
            AddCustomLabel(axisY, 70000);
            AddCustomLabel(axisY, 100000); 
            AddCustomLabel(axisY, 150000);  
            AddCustomLabel(axisY, 200000);  
        }

        private void AddCustomLabel(Axis axis, double value) 
        {
            var lbl = new CustomLabel 
            {
                FromPosition = value - 1, 
                ToPosition = value + 1,
                Text = string.Format("${0:n0}", value)
            };
            axis.CustomLabels.Add(lbl); 
        }
    }
}
