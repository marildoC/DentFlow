using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DENTAL
{
    public partial class adminDashboard : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        private bool columnsConfigured = false;

        public adminDashboard()
        {
            InitializeComponent();


        }

        private void Form_Resize(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                RefreshDashboard();
            }
        }

        public void RefreshDashboard()
        {
            AutoCancelOldAppointments();

            today_appointment.Text = CountTodayAppointments().ToString();
            active_appointment.Text = CountActiveAppointments().ToString();
            canceled_appointment.Text = CountTodayCanceledAppointments().ToString();
            new_patients.Text = CountNewPatientsThisWeek().ToString();

            LoadTodayAppointmentsGrid();
        }

        private void AutoCancelOldAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    UPDATE Appointments
                    SET IsCanceled=1
                    WHERE IsCanceled=0
                      AND DATEADD(HOUR,2,
                          CAST(AppointmentDate as datetime) + CAST(AppointmentTime as datetime)
                      ) < GETDATE()";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int CountTodayAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                   SELECT COUNT(*) FROM Appointments
                   WHERE AppointmentDate = CAST(GETDATE() as date)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private int CountActiveAppointments()
        {
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  SELECT COUNT(*)
                  FROM Appointments
                  WHERE IsCanceled=0
                    AND AppointmentDate = CAST(GETDATE() as date)
                    AND DATEPART(HOUR, AppointmentTime) = DATEPART(HOUR, GETDATE())
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private int CountTodayCanceledAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  SELECT COUNT(*) FROM Appointments
                  WHERE IsCanceled=1
                    AND AppointmentDate = CAST(GETDATE() as date)
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private int CountNewPatientsThisWeek()
        {
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  SELECT COUNT(*)
                  FROM Patients
                  WHERE CreatedAt >= DATEADD(WEEK, DATEDIFF(WEEK,0,GETDATE()), 0)
                    AND CreatedAt < DATEADD(WEEK, DATEDIFF(WEEK,0,GETDATE())+1, 0)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void LoadTodayAppointmentsGrid()
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  SELECT AppointmentID, DentistID, 
                         AppointmentTime, 
                         PatientName,
                         Notes,
                         IsCanceled
                  FROM Appointments
                  WHERE AppointmentDate = CAST(GETDATE() as date)
                  ORDER BY AppointmentTime
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            dt.Columns.Add("DentistName", typeof(string));
            Dictionary<int, string> dentistMap = BuildDentistMap();
            foreach (DataRow row in dt.Rows)
            {
                int did = (int)row["DentistID"];
                if (dentistMap.ContainsKey(did))
                    row["DentistName"] = dentistMap[did];
            }

            dataGridViewToday.DataSource = dt;
            ConfigureGridColumns();
        }


        private Dictionary<int, string> BuildDentistMap()
        {
            var result = new Dictionary<int, string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT DentistID, (Name + ' ' + Surname) AS FullName FROM Dentists";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int did = (int)rdr["DentistID"];
                        string nm = rdr["FullName"].ToString();
                        result[did] = nm;
                    }
                }
            }
            return result;
        }


        private void ConfigureGridColumns() 
        {
            if (!columnsConfigured) 
            {
                dataGridViewToday.Columns["AppointmentID"].Visible = false; 
                dataGridViewToday.Columns["DentistID"].Visible = false;
                dataGridViewToday.Columns["IsCanceled"].Visible = false; 

                dataGridViewToday.Columns["DentistName"].HeaderText = "Dentist";
                dataGridViewToday.Columns["AppointmentTime"].HeaderText = "Time";
                dataGridViewToday.Columns["PatientName"].HeaderText = "Patient";
                dataGridViewToday.Columns["Notes"].HeaderText = "Notes"; 
                //dataGridViewToday.Columns["AppointmentTime"].DefaultCellStyle.Format = "HH:mm";


                if (!dataGridViewToday.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editCol = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        HeaderText = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };

                    dataGridViewToday.Columns.Add(editCol);
                }

                dataGridViewToday.Columns["Edit"].DisplayIndex = dataGridViewToday.Columns.Count - 1;

                columnsConfigured = true;

                Dictionary<string, Color> dentistNameColors = new Dictionary<string, Color>();
                List<Color> colorPalette = new List<Color>
        {
            Color.LightBlue,
            Color.LightGreen,
            Color.LightPink,
            Color.LightYellow,
            Color.LightCoral,
            Color.LightSalmon,
            Color.LightSkyBlue,
            Color.LightGoldenrodYellow,
            Color.LightGray,
            Color.LightCyan
        };

                int colorIndex = 0;

                dataGridViewToday.CellFormatting += (s, e) =>
                {
                    if (dataGridViewToday.Columns[e.ColumnIndex].Name == "DentistName" && e.RowIndex >= 0)
                    {
                        string dentistName = dataGridViewToday.Rows[e.RowIndex].Cells["DentistName"].Value.ToString();

                        if (!dentistNameColors.ContainsKey(dentistName))
                        {
                            dentistNameColors[dentistName] = colorPalette[colorIndex % colorPalette.Count];
                            colorIndex++;
                        }

                        e.CellStyle.BackColor = dentistNameColors[dentistName];
                    } 
                };
            }
        } 







        private void dataGridViewToday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var colName = dataGridViewToday.Columns[e.ColumnIndex].Name;
            int apptId = Convert.ToInt32(dataGridViewToday.Rows[e.RowIndex].Cells["AppointmentID"].Value);

            if (colName == "Edit")
            {
                MainForm parent = this.FindForm() as MainForm;
                if (parent != null)
                {
                    parent.ShowAddAppointmentControl(apptId);
                }
            }
        }




        private void today_appointment_Click(object sender, EventArgs e)
        {

        }

        private void active_appointment_Click(object sender, EventArgs e)
        {    

        }

        private void canceled_appointment_Click(object sender, EventArgs e)
        {
           
        }

        private void new_patients_Click(object sender, EventArgs e)
        {
            
        }


    }
}