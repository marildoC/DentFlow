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
    public partial class addAppointement : UserControl
    {


        private bool _isLoading = false; 


        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";


        private int? currentAppointmentID = null;

        public addAppointement()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                
                LoadDentists();
                listBox_patient.Visible = false;
                dtpApptDate.Value = DateTime.Now;
                maskTime.Text = "";
            }
        }

        public void ReloadData()
        {
            LoadDentists();
        }

        public void ClearForNewAppointment()
        {
            currentAppointmentID = null;
            cmbDentist.SelectedIndex = -1;
            txtPatient.Text = "";
            dtpApptDate.Value = DateTime.Today; 
            maskTime.Text = "";
            txtNotes.Text = "";
            cancel_bttn.Checked = false; 
        }

        public void LoadAppointment(int appointmentID)  
        {
            _isLoading = true;  
            currentAppointmentID = appointmentID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
          SELECT DentistID, PatientName, AppointmentDate, AppointmentTime,
                 Notes, IsCanceled
            FROM Appointments
           WHERE AppointmentID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", appointmentID);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            int dentistID = (int)rdr["DentistID"];
                            foreach (var obj in cmbDentist.Items)
                            {
                                if (obj is DentistItem di && di.DentistID == dentistID)
                                {
                                    cmbDentist.SelectedItem = di;
                                    break;
                                }
                            }

                            txtPatient.Text = rdr["PatientName"].ToString();
                            dtpApptDate.Value = (DateTime)rdr["AppointmentDate"];
                            TimeSpan ts = (TimeSpan)rdr["AppointmentTime"];
                            maskTime.Text = ts.ToString(@"hh\:mm");
                            txtNotes.Text = rdr["Notes"].ToString();

                            cancel_bttn.Checked = false;
                        }
                    }
                }
            }

            _isLoading = false;
        } 

        #region Dentist Combo
        private class DentistItem
        {
            public int DentistID { get; set; }
            public string FullName { get; set; }
            public override string ToString() => FullName;
        }

        private void LoadDentists()
        {
            cmbDentist.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT DentistID, (Name + ' ' + Surname) AS FullName FROM Dentists ORDER BY Name";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        cmbDentist.Items.Add(new DentistItem
                        {
                            DentistID = (int)rdr["DentistID"],
                            FullName = rdr["FullName"].ToString()
                        });
                    }
                }
            }
            cmbDentist.DisplayMember = "FullName";
        }
        #endregion

        #region Patient Suggestions
        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            if (txtPatient.Text.Trim().Length < 2)
            {
                listBox_patient.Visible = false;
                return;
            }
            LoadPatientSuggestions(txtPatient.Text.Trim());
        }

        private void LoadPatientSuggestions(string partial)
        {
            listBox_patient.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  SELECT TOP 20 (Name + ' ' + Surname) AS FullName
                  FROM Patients
                  WHERE Name LIKE @p + '%' 
                     OR Surname LIKE @p + '%'
                  ORDER BY Name
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p", partial);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            listBox_patient.Items.Add(rdr["FullName"].ToString());
                        }
                    }
                }
            }
            listBox_patient.Visible = (listBox_patient.Items.Count > 0);
        }

        private void listBox_patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_patient.SelectedItem != null)
            {
                txtPatient.Text = listBox_patient.SelectedItem.ToString();
                listBox_patient.Visible = false;
            }
        }
        #endregion

        #region Save
        private void save_appointement_bttn_Click(object sender, EventArgs e)
        {
            if (cmbDentist.SelectedItem == null)
            {
                MessageBox.Show("Please select a dentist.");
                return;
            }
            var selectedDentist = (DentistItem)cmbDentist.SelectedItem;

            if (string.IsNullOrWhiteSpace(txtPatient.Text))
            {
                MessageBox.Show("Please enter a patient name.");
                return;
            }

            DateTime dateChosen = dtpApptDate.Value.Date;
            if (dateChosen < DateTime.Today)
            {
                MessageBox.Show("Cannot set an appointment in the past.");
                return;
            }

            if (!TimeSpan.TryParseExact(maskTime.Text, "hh\\:mm", null, out TimeSpan apptTime))
            {
                MessageBox.Show("Please enter a valid time (HH:MM).");
                return;
            }

            if (!IsWithinOpenHours(dateChosen, apptTime))
            {
                MessageBox.Show("That time is outside the clinic's working hours.");
                return;
            }

            if (PatientAlreadyHasFutureAppointment(txtPatient.Text.Trim(), dateChosen))
            {
                MessageBox.Show("This patient already has a future appointment scheduled!");
                return;
            }

            if (currentAppointmentID == null)
            {
                int newID = InsertAppointment(selectedDentist.DentistID,
                                              txtPatient.Text.Trim(),
                                              dateChosen,
                                              apptTime,
                                              txtNotes.Text.Trim());
                currentAppointmentID = newID;
                MessageBox.Show("Appointment saved successfully!");
            }
            else
            {
                UpdateAppointment(currentAppointmentID.Value,
                                  selectedDentist.DentistID,
                                  txtPatient.Text.Trim(),
                                  dateChosen,
                                  apptTime,
                                  txtNotes.Text.Trim(),
                                  cancel_bttn.Checked);
                MessageBox.Show("Appointment updated successfully!");
            }

            MainForm parent = this.FindForm() as MainForm;
            if (parent != null)
            {
                parent.ShowAppointments();
            }
        }

        private bool PatientAlreadyHasFutureAppointment(string patientName, DateTime newApptDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  SELECT COUNT(*)
                  FROM Appointments
                  WHERE PatientName = @pname
                    AND IsCanceled = 0
                    AND AppointmentDate >= @today
                ";
                if (currentAppointmentID != null)
                {
                    sql += " AND AppointmentID <> @excludeID";
                }
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pname", patientName);
                    cmd.Parameters.AddWithValue("@today", DateTime.Today);
                    if (currentAppointmentID != null)
                    {
                        cmd.Parameters.AddWithValue("@excludeID", currentAppointmentID.Value);
                    }

                    int count = (int)cmd.ExecuteScalar();
                    return (count > 0);
                }
            }
        }

        private int InsertAppointment(int dentistID, string patientName,
                                      DateTime apptDate, TimeSpan apptTime,
                                      string notes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  INSERT INTO Appointments 
                    (DentistID, PatientName, AppointmentDate, AppointmentTime, 
                     Notes, IsCanceled)
                  OUTPUT INSERTED.AppointmentID
                  VALUES
                    (@did, @pname, @dt, @tm, @notes, 0)
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@did", dentistID);
                    cmd.Parameters.AddWithValue("@pname", patientName);
                    cmd.Parameters.AddWithValue("@dt", apptDate);
                    cmd.Parameters.AddWithValue("@tm", apptTime);
                    cmd.Parameters.AddWithValue("@notes", notes ?? "");
                    int newId = (int)cmd.ExecuteScalar();
                    return newId;
                }
            }
        }

        private void UpdateAppointment(int apptID, int dentistID, 
                                       string patientName,
                                       DateTime apptDate,
                                       TimeSpan apptTime,
                                       string notes,
                                       bool isCanceled)
        { 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  UPDATE Appointments
                     SET DentistID=@did,
                         PatientName=@pname,
                         AppointmentDate=@dt,
                         AppointmentTime=@tm,
                         Notes=@notes,
                         IsCanceled=@iscancel
                   WHERE AppointmentID=@aid
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@did", dentistID);
                    cmd.Parameters.AddWithValue("@pname", patientName);
                    cmd.Parameters.AddWithValue("@dt", apptDate);
                    cmd.Parameters.AddWithValue("@tm", apptTime);
                    cmd.Parameters.AddWithValue("@notes", notes ?? "");
                    cmd.Parameters.AddWithValue("@iscancel", isCanceled);
                    cmd.Parameters.AddWithValue("@aid", apptID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Cancel
        private void cancel_bttn_CheckedChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            if (cancel_bttn.Checked)
            {
                if (currentAppointmentID != null)
                {
                    var dr = MessageBox.Show(
                        "Are you sure you want to CANCEL (delete) this appointment?",
                        "Confirm Cancel",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (dr == DialogResult.Yes)
                    {
                        DeleteAppointment(currentAppointmentID.Value);
                        MessageBox.Show("Appointment deleted.");
                        ClearFields();
                        currentAppointmentID = null;
                        cancel_bttn.Checked = false;
                    }
                    else
                    {
                        cancel_bttn.Checked = false;
                    }
                }
                else
                {
                    ClearFields();
                    cancel_bttn.Checked = false;
                }
            }
        }


        private void DeleteAppointment(int apptID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Appointments WHERE AppointmentID=@id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", apptID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ClearFields()
        {
            currentAppointmentID = null;
            cmbDentist.SelectedIndex = -1;
            txtPatient.Text = "";
            dtpApptDate.Value = DateTime.Today;
            maskTime.Text = "";
            txtNotes.Text = "";
        }
        #endregion

        #region Checking Clinic Hours
        private bool IsWithinOpenHours(DateTime chosenDate, TimeSpan chosenTime)
        {
            int dow = (int)chosenDate.DayOfWeek;
            var schedule = GetDaySchedule(dow);
            if (schedule == null) return false;

            bool inFirstSlot = false;
            bool inSecondSlot = false;

            if (!string.IsNullOrWhiteSpace(schedule.Item1) &&
                !string.IsNullOrWhiteSpace(schedule.Item2))
            {
                if (TimeSpan.TryParse(schedule.Item1, out TimeSpan open1) &&
                    TimeSpan.TryParse(schedule.Item2, out TimeSpan close1))
                {
                    if (open1 <= close1)
                    {
                        inFirstSlot = (chosenTime >= open1 && chosenTime <= close1);
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(schedule.Item3) &&
                !string.IsNullOrWhiteSpace(schedule.Item4))
            {
                if (TimeSpan.TryParse(schedule.Item3, out TimeSpan open2) &&
                    TimeSpan.TryParse(schedule.Item4, out TimeSpan close2))
                {
                    if (open2 <= close2)
                    {
                        inSecondSlot = (chosenTime >= open2 && chosenTime <= close2);
                    }
                }
            }

            return inFirstSlot || inSecondSlot;
        }

        private Tuple<string, string, string, string> GetDaySchedule(int dayOfWeek)
        {
            string prefix = dayOfWeek switch
            {
                0 => "Sun",
                1 => "Mon",
                2 => "Tue",
                3 => "Wed",
                4 => "Thu",
                5 => "Fri",
                6 => "Sat",
                _ => "Mon"
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = $@"
                  SELECT {prefix}Open1, {prefix}Close1,
                         {prefix}Open2, {prefix}Close2
                    FROM ClinicSettings
                   WHERE SettingsID=1
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        string o1 = rdr[$"{prefix}Open1"]?.ToString().Trim() ?? "";
                        string c1 = rdr[$"{prefix}Close1"]?.ToString().Trim() ?? "";
                        string o2 = rdr[$"{prefix}Open2"]?.ToString().Trim() ?? "";
                        string c2 = rdr[$"{prefix}Close2"]?.ToString().Trim() ?? "";
                        return Tuple.Create(o1, c1, o2, c2);
                    }
                }
            }
            return null;
        }
        #endregion

        private void label7_Click(object sender, EventArgs e)
        {
            MainForm parent = this.FindForm() as MainForm;
            if (parent != null)
            {
                parent.ShowAppointments();
            } 

        }  

        private void dtpApptDate_ValueChanged(object sender, EventArgs e) { }
        private void maskTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void txtNotes_TextChanged(object sender, EventArgs e) { }

        private void addAppointement_Load(object sender, EventArgs e)
        {

        }

       
    }
}
