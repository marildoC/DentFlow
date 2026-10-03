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
    public partial class MainForm : Form
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string storedName = GetSavedClinicNameFromDB();
            SetClinicTitle(storedName);

            ShowDashboard();
        }

        private string GetSavedClinicNameFromDB()
        {
            string name = "Name of Clinic"; 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ClinicName FROM ClinicSettings WHERE SettingsID=1";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        object obj = cmd.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            name = obj.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clinic name: " + ex.Message);
            }
            return name;
        }

        public void SetClinicTitle(string clinicName)
        {
            lblClinicName.Text = clinicName;
        }

       

        public void ShowDashboard()
        {
            adminDashboard1.Visible = true;
            patients1.Visible = false;
            addPatient1.Visible = false;
            appointments1.Visible = false;
            addAppointement1.Visible = false;
            setting1.Visible = false;
            dentists1.Visible = false;
            treatment1.Visible = false; 

            adminDashboard1.BringToFront();

            adminDashboard1.RefreshDashboard();
        }

        public void ShowPatients()
        {
            adminDashboard1.Visible = false;
            patients1.Visible = true;
            addPatient1.Visible = false;
            appointments1.Visible = false;
            addAppointement1.Visible = false;
            setting1.Visible = false;
            dentists1.Visible = false;
            treatment1.Visible = false;

            patients1.BringToFront();
            patients1.displayAddPatient();
        }

        public void ShowAddPatientControl(int patientId)
        {
            adminDashboard1.Visible = false;
            patients1.Visible = false;
            appointments1.Visible = false;
            addAppointement1.Visible = false;
            setting1.Visible = false;
            dentists1.Visible = false;
            treatment1.Visible = false;

            addPatient1.Visible = true;
            addPatient1.BringToFront();
            addPatient1.LoadPatientData(patientId);
        }

        public void ShowDentists()
        {
            adminDashboard1.Visible = false;
            patients1.Visible = false;
            addDentists1.Visible = false;
            appointments1.Visible = false;
            addAppointement1.Visible = false;
            setting1.Visible = false;
            treatment1.Visible = false;

            dentists1.Visible = true;
            dentists1.BringToFront();
            dentists1.DisplayDentists();
        }

        public void ShowAddDentistsControl(int dentistId)
        {
            dentists1.Visible = false;

            addDentists1.Visible = true;
            addDentists1.BringToFront();
            addDentists1.LoadDentistData(dentistId);
        }

        public void ShowSettings()
        {
            adminDashboard1.Visible = false;
            patients1.Visible = false;
            addDentists1.Visible = false;
            appointments1.Visible = false;
            addAppointement1.Visible = false;
            dentists1.Visible = false;
            treatment1.Visible = false; 

            setting1.Visible = true;
            setting1.BringToFront();
        }

        public void ShowAppointments()
        {
            adminDashboard1.Visible = false;
            patients1.Visible = false;
            addPatient1.Visible = false;
            setting1.Visible = false;
            dentists1.Visible = false;
            addAppointement1.Visible = false;
           treatment1.Visible = false;

            appointments1.ReloadActive();
            appointments1.Visible = true;
            appointments1.BringToFront();
        }

        public void ShowAddAppointmentControl(int appointmentID)
        {
            appointments1.Visible = true;  
            addAppointement1.ReloadData();
            addAppointement1.Visible = true;
            addAppointement1.BringToFront();

            if (appointmentID == 0)
            {
                addAppointement1.ClearForNewAppointment();
            }
            else
            {
                addAppointement1.LoadAppointment(appointmentID);
            }
        }

        
        public void ShowTreatment(int appointmentId, string patientName, string dentistName)
        {
            treatment1.SetData(appointmentId, patientName, dentistName);

            treatment1.Visible = true; 
            treatment1.BringToFront();

            appointments1.Visible = true;

            adminDashboard1.Visible = false;
            patients1.Visible = false;
            addPatient1.Visible = false;
            dentists1.Visible = false;
            addDentists1.Visible = false;
            addAppointement1.Visible = false;
            setting1.Visible = false;




        }


        public void ShowRevenues()
        {
            adminDashboard1.Visible = false;
            patients1.Visible = false;
            addPatient1.Visible = false;
            appointments1.Visible = false;
            addAppointement1.Visible = false;
            setting1.Visible = false;
            dentists1.Visible = false;

            revenues1.Visible = true;
            revenues1.BringToFront(); 
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {
        }


        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            Form1 loginForm = new Form1();

            loginForm.Show();

            this.Close();
        }


        private void patientForm1_Load_1(object sender, EventArgs e)
        {
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPatients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void dentist_bttn_Click(object sender, EventArgs e)
        {
            ShowDentists();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void appointements_button_Click(object sender, EventArgs e)
        {
            ShowAppointments();
        }

        private void settings_bttn_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void revenue_btt_Click(object sender, EventArgs e)
        {
            ShowRevenues();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
