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
    public partial class dentists : UserControl
    {

        private List<dentistsC> allDentists;  
        private bool columnsAdded = false;
        public dentists()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                DisplayDentists();
                MakeDataGridViewReadOnly();

               
            }
        }

        public void DisplayDentists()
        {
            try
            {
                dentistsC dData = new dentistsC(); 
                allDentists = dData.listDentists();

                dataGridView1.DataSource = allDentists;

                dataGridView1.Columns["DentistID"].Visible = false;

                if (!columnsAdded)
                {
                    AddButtonColumns();
                    columnsAdded = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dentist data: " + ex.Message,
                                "Load Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void AddButtonColumns()
        {
            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editCol);

            DataGridViewButtonColumn delCol = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(delCol);
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            int dentistId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DentistID"].Value);

            if (colName == "Edit")
            {
                EditDentist(dentistId);
            }
            else if (colName == "Delete")
            {
                DeleteDentist(dentistId);
            }
        }


        private void EditDentist(int dentistId)
        {
            MainForm parentForm = this.FindForm() as MainForm;
            if (parentForm != null)
            {
                
                parentForm.ShowAddDentistsControl(dentistId);
            }
        }

        private void DeleteDentist(int dentistId)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this dentist?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"))
                    {
                        conn.Open();

                        
                        string selectImgs = "SELECT ImagePath FROM DentistImages WHERE DentistID = @did";
                        List<string> imagePaths = new List<string>();
                        using (SqlCommand cmdSel = new SqlCommand(selectImgs, conn))
                        {
                            cmdSel.Parameters.AddWithValue("@did", dentistId);
                            using (SqlDataReader r = cmdSel.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    imagePaths.Add(r["ImagePath"].ToString());
                                }
                            }
                        }

                        foreach (var path in imagePaths)
                        {
                            if (System.IO.File.Exists(path))
                            {
                                try { System.IO.File.Delete(path); }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error deleting image file: " + ex.Message,
                                                    "File Deletion Error",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                }
                            }
                        }

                        string delImgs = "DELETE FROM DentistImages WHERE DentistID = @did";
                        using (SqlCommand cmdImgs = new SqlCommand(delImgs, conn))
                        {
                            cmdImgs.Parameters.AddWithValue("@did", dentistId);
                            cmdImgs.ExecuteNonQuery();
                        }

                        string delDentist = "DELETE FROM Dentists WHERE DentistID = @did";
                        using (SqlCommand cmdD = new SqlCommand(delDentist, conn))
                        {
                            cmdD.Parameters.AddWithValue("@did", dentistId);
                            int rows = cmdD.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Dentist record deleted successfully.",
                                                "Deletion Success",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No dentist found with that ID.",
                                                "Deletion Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                        }
                    }

                    DisplayDentists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting dentist: " + ex.Message,
                                    "Deletion Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }






        private void AddNewDentist()
        {
            MainForm parentForm = this.FindForm() as MainForm;
            if (parentForm != null)
            {
                parentForm.ShowAddDentistsControl(0);
            }
        }









        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewDentist();

        }



        private void search_filter_TextChanged(object sender, EventArgs e)
        {
            if (allDentists == null) return;

            string search = search_filter.Text.Trim().ToLower(); 

            var filtered = allDentists
                .Where(d => d.Name.ToLower().StartsWith(search)
                         || d.Surname.ToLower().StartsWith(search))
                .ToList();

            dataGridView1.DataSource = filtered;

        }

        private void refresh_field_Click(object sender, EventArgs e) 
        {
            search_filter.Text = "";

        }

        private void dentists_Load(object sender, EventArgs e)
        {

        }
    }
}
