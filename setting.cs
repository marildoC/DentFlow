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
    public partial class setting : UserControl
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";
        public setting()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                EnsureSettingsRowExists();
                LoadSettingsFromDB();


            }
        }


        private void EnsureSettingsRowExists()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlCheck = "SELECT COUNT(*) FROM ClinicSettings WHERE SettingsID = 1";
                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn))
                    {
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count == 0)
                        {
                            string sqlInsert = @"
                            INSERT INTO ClinicSettings (SettingsID, ClinicName)
                            VALUES (1, 'Default Clinic')
                        ";
                            using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn))
                            {
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ensuring default ClinicSettings row: " + ex.Message);
            }
        }

        private void LoadSettingsFromDB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM ClinicSettings WHERE SettingsID = 1";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtClinicName.Text = reader["ClinicName"]?.ToString() ?? "";

                            mtbMonOpen1.Text = reader["MonOpen1"]?.ToString() ?? "";
                            mtbMonClose1.Text = reader["MonClose1"]?.ToString() ?? "";
                            mtbMonOpen2.Text = reader["MonOpen2"]?.ToString() ?? "";
                            mtbMonClose2.Text = reader["MonClose2"]?.ToString() ?? "";

                            mtbTueOpen1.Text = reader["TueOpen1"]?.ToString() ?? "";
                            mtbTueClose1.Text = reader["TueClose1"]?.ToString() ?? "";
                            mtbTueOpen2.Text = reader["TueOpen2"]?.ToString() ?? "";
                            mtbTueClose2.Text = reader["TueClose2"]?.ToString() ?? "";

                            mtbWedOpen1.Text = reader["WedOpen1"]?.ToString() ?? "";
                            mtbWedClose1.Text = reader["WedClose1"]?.ToString() ?? "";
                            mtbWedOpen2.Text = reader["WedOpen2"]?.ToString() ?? "";
                            mtbWedClose2.Text = reader["WedClose2"]?.ToString() ?? "";

                            mtbThurOpen1.Text = reader["ThuOpen1"]?.ToString() ?? "";
                            mtbThurClose1.Text = reader["ThuClose1"]?.ToString() ?? "";
                            mtbThurOpen2.Text = reader["ThuOpen2"]?.ToString() ?? "";
                            mtbThurClose2.Text = reader["ThuClose2"]?.ToString() ?? "";

                            mtbFriOpen1.Text = reader["FriOpen1"]?.ToString() ?? "";
                            mtbFriClose1.Text = reader["FriClose1"]?.ToString() ?? "";
                            mtbFriOpen2.Text = reader["FriOpen2"]?.ToString() ?? "";
                            mtbFriClose2.Text = reader["FriClose2"]?.ToString() ?? "";

                            mtbSatOpen1.Text = reader["SatOpen1"]?.ToString() ?? "";
                            mtbSatClose1.Text = reader["SatClose1"]?.ToString() ?? "";
                            mtbSatOpen2.Text = reader["SatOpen2"]?.ToString() ?? "";
                            mtbSatClose2.Text = reader["SatClose2"]?.ToString() ?? "";

                            
                            mtbSunOpen1.Text = reader["SunOpen1"]?.ToString() ?? "";
                            mtbSunClose1.Text = reader["SunClose1"]?.ToString() ?? "";
                            mtbSunOpen2.Text = reader["SunOpen2"]?.ToString() ?? "";
                            mtbSunClose2.Text = reader["SunClose2"]?.ToString() ?? "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message);
            }
        }




        private void Save_setting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClinicName.Text))
            {
                MessageBox.Show("Please enter a dental clinic name.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateSql = @"
                        UPDATE ClinicSettings
                           SET 
                               ClinicName = @ClinicName,

                               MonOpen1  = @MonOpen1,
                               MonClose1 = @MonClose1,
                               MonOpen2  = @MonOpen2,
                               MonClose2 = @MonClose2,

                               TueOpen1  = @TueOpen1,
                               TueClose1 = @TueClose1,
                               TueOpen2  = @TueOpen2,
                               TueClose2 = @TueClose2,

                               WedOpen1  = @WedOpen1,
                               WedClose1 = @WedClose1,
                               WedOpen2  = @WedOpen2,
                               WedClose2 = @WedClose2,

                               ThuOpen1  = @ThuOpen1,
                               ThuClose1 = @ThuClose1,
                               ThuOpen2  = @ThuOpen2,
                               ThuClose2 = @ThuClose2,

                               FriOpen1  = @FriOpen1,
                               FriClose1 = @FriClose1,
                               FriOpen2  = @FriOpen2,
                               FriClose2 = @FriClose2,

                               SatOpen1  = @SatOpen1,
                               SatClose1 = @SatClose1,
                               SatOpen2  = @SatOpen2,
                               SatClose2 = @SatClose2,

                               SunOpen1  = @SunOpen1,
                               SunClose1 = @SunClose1,
                               SunOpen2  = @SunOpen2,
                               SunClose2 = @SunClose2

                         WHERE SettingsID = 1 
                    ";

                    using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClinicName", txtClinicName.Text);

                        

                        cmd.Parameters.AddWithValue("@MonOpen1", ToDbValue(mtbMonOpen1.Text));
                        cmd.Parameters.AddWithValue("@MonClose1", ToDbValue(mtbMonClose1.Text));
                        cmd.Parameters.AddWithValue("@MonOpen2", ToDbValue(mtbMonOpen2.Text));
                        cmd.Parameters.AddWithValue("@MonClose2", ToDbValue(mtbMonClose2.Text));

                        cmd.Parameters.AddWithValue("@TueOpen1", ToDbValue(mtbTueOpen1.Text));
                        cmd.Parameters.AddWithValue("@TueClose1", ToDbValue(mtbTueClose1.Text));
                        cmd.Parameters.AddWithValue("@TueOpen2", ToDbValue(mtbTueOpen2.Text));
                        cmd.Parameters.AddWithValue("@TueClose2", ToDbValue(mtbTueClose2.Text));

                        cmd.Parameters.AddWithValue("@WedOpen1", ToDbValue(mtbWedOpen1.Text));
                        cmd.Parameters.AddWithValue("@WedClose1", ToDbValue(mtbWedClose1.Text));
                        cmd.Parameters.AddWithValue("@WedOpen2", ToDbValue(mtbWedOpen2.Text));
                        cmd.Parameters.AddWithValue("@WedClose2", ToDbValue(mtbWedClose2.Text));

                        cmd.Parameters.AddWithValue("@ThuOpen1", ToDbValue(mtbThurOpen1.Text));
                        cmd.Parameters.AddWithValue("@ThuClose1", ToDbValue(mtbThurClose1.Text));
                        cmd.Parameters.AddWithValue("@ThuOpen2", ToDbValue(mtbThurOpen2.Text));
                        cmd.Parameters.AddWithValue("@ThuClose2", ToDbValue(mtbThurClose2.Text));

                        cmd.Parameters.AddWithValue("@FriOpen1", ToDbValue(mtbFriOpen1.Text));
                        cmd.Parameters.AddWithValue("@FriClose1", ToDbValue(mtbFriClose1.Text));
                        cmd.Parameters.AddWithValue("@FriOpen2", ToDbValue(mtbFriOpen2.Text));
                        cmd.Parameters.AddWithValue("@FriClose2", ToDbValue(mtbFriClose2.Text));

                        cmd.Parameters.AddWithValue("@SatOpen1", ToDbValue(mtbSatOpen1.Text));
                        cmd.Parameters.AddWithValue("@SatClose1", ToDbValue(mtbSatClose1.Text));
                        cmd.Parameters.AddWithValue("@SatOpen2", ToDbValue(mtbSatOpen2.Text));
                        cmd.Parameters.AddWithValue("@SatClose2", ToDbValue(mtbSatClose2.Text));

                        cmd.Parameters.AddWithValue("@SunOpen1", ToDbValue(mtbSunOpen1.Text));
                        cmd.Parameters.AddWithValue("@SunClose1", ToDbValue(mtbSunClose1.Text));
                        cmd.Parameters.AddWithValue("@SunOpen2", ToDbValue(mtbSunOpen2.Text));
                        cmd.Parameters.AddWithValue("@SunClose2", ToDbValue(mtbSunClose2.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Settings saved successfully.",
                                "Save",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                MainForm parentForm = this.FindForm() as MainForm;
                if (parentForm != null)
                {
                    parentForm.SetClinicTitle(txtClinicName.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message);
            }
        }
        private object ToDbValue(string maskedText)
        {
            if (string.IsNullOrWhiteSpace(maskedText) || maskedText.Contains("_"))
                return DBNull.Value;

            return maskedText.Trim();
        }





        private void refresh_fields_Click(object sender, EventArgs e)
        {
            txtClinicName.Text = "";

            mtbMonOpen1.Text = "";
            mtbMonClose1.Text = "";
            mtbMonOpen2.Text = "";
            mtbMonClose2.Text = "";

            mtbTueOpen1.Text = "";
            mtbTueClose1.Text = "";
            mtbTueOpen2.Text = "";
            mtbTueClose2.Text = "";

            mtbWedOpen1.Text = "";
            mtbWedClose1.Text = "";
            mtbWedOpen2.Text = "";
            mtbWedClose2.Text = "";

            mtbThurOpen1.Text = "";
            mtbThurClose1.Text = "";
            mtbThurOpen2.Text = "";
            mtbThurClose2.Text = "";

            mtbFriOpen1.Text = "";
            mtbFriClose1.Text = "";
            mtbFriOpen2.Text = "";
            mtbFriClose2.Text = "";

            mtbSatOpen1.Text = "";
            mtbSatClose1.Text = "";
            mtbSatOpen2.Text = "";
            mtbSatClose2.Text = "";

            mtbSunOpen1.Text = "";
            mtbSunClose1.Text = "";
            mtbSunOpen2.Text = "";
            mtbSunClose2.Text = "";
        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Monday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Tuesday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Wednesday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Thursday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Friday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Saturday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Sunday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textClinicName_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtMonOpen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonClose1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonOpen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonClose2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTueOpen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTueClose1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTueOpen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTueClose2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWedOpen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWedClose1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWedOpen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWedClose2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThurOpen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThurClose1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThurOpen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThurClose2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFriOpen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFriClose1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFriOpen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFriClose2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSatOpen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSatClose1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSatOpen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSatClose2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSunOpen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSunClose1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSunOpen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSunClose2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbMonOpen1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbMonClose1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbMonOpen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbMonClose2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbTueOpen1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbTueClose1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbTueOpen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbTueClose2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbWedOpen1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbWedClose1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbWedOpen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbWedClose2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbThurOpen1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbThurClose1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbThurOpen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbThurClose2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbFriOpen1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbFriClose1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbFriOpen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbFriClose2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSatOpen1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSatClose1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSatOpen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSatClose2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSunOpen1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSunClose1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSunOpen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbSunClose2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void setting_Load(object sender, EventArgs e)
        {

        }
    }
}

