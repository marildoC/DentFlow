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
using System.Text.RegularExpressions; 
using BCrypt.Net; 



namespace DENTAL   
{
    public partial class patients : UserControl
    {

        private List<patientC> allPatients;


        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";


        private bool columnsAdded = false;
        public patients()
        {
            InitializeComponent();
        }

        private void patients_Load_1(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                displayAddPatient();

                MakeDataGridViewReadOnly(); 
            }
        }

        private void AddButtonColumns()
        {
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteColumn);
        }


        public void displayAddPatient()
        {
            try
            {
                patientC pData = new patientC();
                allPatients = pData.listPatientC(); 

                dataGridView1.DataSource = allPatients;

                dataGridView1.Columns["PatientID"].Visible = false;


                if (!columnsAdded)
                {
                    AddButtonColumns();  
                    columnsAdded = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load patient data: " + ex.Message,
                                "Load Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        } 





        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                int patientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);

                if (columnName == "Edit")
                {
                    EditPatient(patientId);
                }
                else if (columnName == "Delete")
                {
                    DeletePatient(patientId);
                }
            }
        }




        private void EditPatient(int patientId)
        {
            MainForm parentForm = this.FindForm() as MainForm;
            if (parentForm != null)
            {
                parentForm.ShowAddPatientControl(patientId);
            }
        }

        private void DeletePatient(int patientId)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"))
                    {
                        conn.Open();

                        string selectImages = "SELECT ImagePath FROM PatientImages WHERE PatientID = @pid";
                        using (SqlCommand cmdSelectImages = new SqlCommand(selectImages, conn))
                        {
                            cmdSelectImages.Parameters.AddWithValue("@pid", patientId);
                            using (SqlDataReader readerImages = cmdSelectImages.ExecuteReader())
                            {
                                List<string> imagePaths = new List<string>();
                                while (readerImages.Read())
                                {
                                    string imagePath = readerImages["ImagePath"].ToString();
                                    if (File.Exists(imagePath))
                                    {
                                        imagePaths.Add(imagePath);
                                    }
                                }
                                readerImages.Close();

                                foreach (string path in imagePaths)
                                {
                                    try
                                    {
                                        File.Delete(path);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Error deleting image file: {ex.Message}", "File Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }

                        string delImages = "DELETE FROM PatientImages WHERE PatientID = @pid";
                        using (SqlCommand cmdImages = new SqlCommand(delImages, conn))
                        {
                            cmdImages.Parameters.AddWithValue("@pid", patientId);
                            cmdImages.ExecuteNonQuery();
                        }

                        string deleteSql = "DELETE FROM Patients WHERE PatientID = @pid";
                        using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@pid", patientId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Patient deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No patient found with that ID.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    displayAddPatient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting patient: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewPatient();
        }

        private void AddNewPatient()
        {
            MainForm parentForm = this.FindForm() as MainForm;
            if (parentForm != null)
            {
                parentForm.ShowAddPatientControl(0); 
            }
        }

        private void search_filter_TextChanged(object sender, EventArgs e)
        {
            if (allPatients == null) return; 

            string search = search_filter.Text.Trim().ToLower();

            var filtered = allPatients
                .Where(p => p.Name.ToLower().StartsWith(search)
                         || p.Surname.ToLower().StartsWith(search))
                .ToList();

            dataGridView1.DataSource = filtered;
        } 

        private void refresh_field_Click(object sender, EventArgs e)
        {

            search_filter.Text = "";
           
        }



        private void MakeDataGridViewReadOnly()
        {
            dataGridView1.ReadOnly = true;          
            dataGridView1.AllowUserToAddRows = false; 
            dataGridView1.AllowUserToDeleteRows = false; 

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

    }

}
