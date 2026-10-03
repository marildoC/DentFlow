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
    public partial class Appointments : UserControl
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        private bool columnsAddedActive = false;
        private bool columnsAddedCancelled = false;

        public Appointments()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                AutoCancelOldAppointments();

                ShowActiveAppointments();
                dataGridView1.BringToFront();
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;

                create_treatment_session.Visible = false;

                pick_day_appointment.ShowCheckBox = true;
                pick_day_appointment.Checked = false;
            }
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
                        CAST(AppointmentDate as datetime)+CAST(AppointmentTime as datetime)
                    ) < GETDATE()";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ReloadActive()
        {
            ShowActiveAppointments();
        }

        private void active_bttn_Click(object sender, EventArgs e)
        {
            ShowActiveAppointments();
        }

        private void cancelled_bttn_Click(object sender, EventArgs e)
        {
            ShowCancelledAppointments();
        }

        private void add_appointment_Click(object sender, EventArgs e)
        {
            MainForm parent = this.FindForm() as MainForm;
            if (parent != null)
            {
                parent.ShowAddAppointmentControl(0); 
            }
        }

        private void create_treatment_session_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1.Visible ? dataGridView1 : dataGridView2;
            if (dgv.SelectedRows.Count > 0)
            {
                int apptID = Convert.ToInt32(dgv.SelectedRows[0].Cells["AppointmentID"].Value);
                string pName = dgv.SelectedRows[0].Cells["PatientName"].Value.ToString();
                string dName = dgv.SelectedRows[0].Cells["DentistName"].Value.ToString();

                MainForm parent = this.FindForm() as MainForm;
                if (parent != null)
                {
                    parent.ShowTreatment(apptID, pName, dName);
                }
            }
        }


        private void search_filter_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) ShowActiveAppointments();
            else ShowCancelledAppointments();
        }

        private void pick_day_appointment_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) ShowActiveAppointments();
            else ShowCancelledAppointments();
        }

        private void refresh_field_Click_1(object sender, EventArgs e)
        {
            search_filter.Text = "";
            pick_day_appointment.Value = DateTime.Today;
            pick_day_appointment.Checked = false;

            if (dataGridView1.Visible) ShowActiveAppointments();
            else ShowCancelledAppointments();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "PatientName")
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                create_treatment_session.Visible = true;
            }
            else
            {
                create_treatment_session.Visible = false;
            }

            int apptID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AppointmentID"].Value);

            if (colName == "Edit")
            {
                MainForm parent = this.FindForm() as MainForm;
                if (parent != null)
                {
                    parent.ShowAddAppointmentControl(apptID);
                }
            }
            else if (colName == "Delete")
            {
                var dr = MessageBox.Show("Sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DeleteAppointment(apptID);
                    ShowActiveAppointments();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;

            if (colName == "PatientName")
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;
                create_treatment_session.Visible = true;
            }
            else
            {
                create_treatment_session.Visible = false;
            }

            int apptID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["AppointmentID"].Value);

            if (colName == "Edit")
            {
                MainForm parent = this.FindForm() as MainForm;
                if (parent != null)
                {
                    parent.ShowAddAppointmentControl(apptID);
                }
            }
            else if (colName == "Delete")
            {
                var dr = MessageBox.Show("Sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DeleteAppointment(apptID);
                    ShowCancelledAppointments();
                }
            }
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            create_treatment_session.Visible = (dataGridView1.SelectedRows.Count > 0);
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            create_treatment_session.Visible = (dataGridView2.SelectedRows.Count > 0);
        }

        private void ShowActiveAppointments()
        {
            DataTable dt = LoadAppointments(isCanceled: false);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;

            if (!columnsAddedActive)
            {
                SetupGridColumns(dataGridView1);
                columnsAddedActive = true;
            }
        }

        private void ShowCancelledAppointments()
        {
            DataTable dt = LoadAppointments(isCanceled: true);
            dataGridView2.DataSource = dt;
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;

            if (!columnsAddedCancelled)
            {
                SetupGridColumns(dataGridView2);
                columnsAddedCancelled = true;
            }
        }

        private DataTable LoadAppointments(bool isCanceled)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                  SELECT 
                    AppointmentID,
                    PatientName,
                    AppointmentDate,
                    AppointmentTime,
                    DentistID,
                    CreatedAt,
                    IsCanceled
                  FROM Appointments
                  WHERE IsCanceled = @c
                ";

                sql += BuildWhereClause();
                sql += " ORDER BY AppointmentDate ASC, AppointmentTime ASC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@c", isCanceled);

                    if (!string.IsNullOrWhiteSpace(search_filter.Text))
                    {
                        cmd.Parameters.AddWithValue("@search", search_filter.Text.Trim() + "%");
                    }
                    if (pick_day_appointment.Checked)
                    {
                        cmd.Parameters.AddWithValue("@theDate", pick_day_appointment.Value.Date);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            dt.Columns.Add("DentistName", typeof(string));
            Dictionary<int, string> map = GetDentistMap();
            foreach (DataRow row in dt.Rows)
            {
                int did = Convert.ToInt32(row["DentistID"]);
                if (map.ContainsKey(did))
                    row["DentistName"] = map[did];
            }
            return dt;
        }

        private string BuildWhereClause()
        {
            List<string> conds = new List<string>();

            if (!string.IsNullOrWhiteSpace(search_filter.Text))
            {
                conds.Add("PatientName LIKE @search");
            }
            if (pick_day_appointment.Checked)
            {
                conds.Add("AppointmentDate = @theDate");
            }
            if (conds.Count == 0) return "";
            return " AND " + string.Join(" AND ", conds);
        }

        private Dictionary<int, string> GetDentistMap()
        {
            Dictionary<int, string> dmap = new Dictionary<int, string>();
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
                        string fname = rdr["FullName"].ToString();
                        dmap[did] = fname;
                    }
                }
            }
            return dmap;
        }

        private void SetupGridColumns(DataGridView dgv)
        {
            dgv.Columns["AppointmentID"].Visible = false;
            dgv.Columns["DentistID"].Visible = false;
            dgv.Columns["IsCanceled"].Visible = false;

            dgv.Columns["PatientName"].HeaderText = "Patient";
            dgv.Columns["AppointmentDate"].HeaderText = "Date";
            dgv.Columns["AppointmentTime"].HeaderText = "Time";
            dgv.Columns["CreatedAt"].HeaderText = "Created";
            dgv.Columns["DentistName"].HeaderText = "Dentist";

            if (!dgv.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editCol = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(editCol);
            }
            if (!dgv.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn delCol = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(delCol);
            }
        }

        private void DeleteAppointment(int appointmentID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Appointments WHERE AppointmentID = @aid";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@aid", appointmentID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            
        }

        private void Appointments_Load_1(object sender, EventArgs e)
        {

        }
    }
}
