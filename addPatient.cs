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
using System.Xml.Linq;
using System.IO; 

namespace DENTAL  
{
    public partial class addPatient : UserControl
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        public addPatient()
        {
            InitializeComponent();
            imageList1.ImageSize = new Size(200, 100);

        }

        public void SetPatientDetails(string name, string surname, string phone, string email, string gender, DateTime dob, string allergies, string treated)
        {
            field_name.Text = name;
            field_surname.Text = surname;
            field_phone.Text = phone;
            field_email.Text = email;
            field_gender.SelectedItem = gender; 
            DOB.Value = dob;
            allergies_field.Text = allergies;
            treated_formula.Text = treated;
        }




        public void LoadPatientData(int patientId)
        {
            if (patientId == 0)
            {
                clear_fields_addP_Click(this, EventArgs.Empty);
                txtPatientId.Text = ""; 

                imageList1.Images.Clear();
                listView1.Items.Clear();
                pictureBoxPreview.Image = null;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Name, Surname, Phone, Email, Gender, DOB, Allergies, Treated FROM Patients WHERE PatientID = @PatientID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SetPatientDetails(
                                reader["Name"].ToString(),
                                reader["Surname"].ToString(),
                                reader["Phone"].ToString(),
                                reader["Email"].ToString(),
                                reader["Gender"].ToString(),
                                Convert.ToDateTime(reader["DOB"]),
                                reader["Allergies"].ToString(),
                                reader["Treated"].ToString()
                            );
                            txtPatientId.Text = patientId.ToString();
                        }
                    }

                    string imagesQuery = "SELECT ImagePath FROM PatientImages WHERE PatientID = @PatientID";
                    SqlCommand cmdImages = new SqlCommand(imagesQuery, conn);
                    cmdImages.Parameters.AddWithValue("@PatientID", patientId);

                    using (SqlDataReader readerImages = cmdImages.ExecuteReader())
                    {
                        imageList1.Images.Clear();
                        listView1.Items.Clear();

                        while (readerImages.Read())
                        {
                            string imagePath = readerImages["ImagePath"].ToString();
                            if (File.Exists(imagePath))
                            {
                                try
                                {
                                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        using (Image tempImg = Image.FromStream(ms))
                                        {
                                            Image originalImage = (Image)tempImg.Clone();
                                            Image thumbnailImage = ResizeImage(originalImage, new Size(200, 100));

                                            imageList1.Images.Add(thumbnailImage);
                                            listView1.Items.Add(new ListViewItem
                                            {
                                                ImageIndex = imageList1.Images.Count - 1,
                                                Tag = new PatientImage
                                                {
                                                    ImagePath = imagePath,
                                                    OriginalImage = originalImage
                                                }
                                            });
                                        }
                                    }
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error loading image: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                
                            }
                        }

                        pictureBoxPreview.Image = null; 
                    }
                }
            }
        }








        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            listView1.Width = this.Width - 20; 
            listView1.Height = this.Height - 60; 
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var patientImage = selectedItem.Tag as PatientImage;
                if (patientImage != null)
                {
                    pictureBoxPreview.Image = patientImage.OriginalImage;
                }
            }
            else
            {
                pictureBoxPreview.Image = null; 
            }
        }


        private void import_Image_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    if (File.Exists(filename))
                    {
                        try
                        {
                            string appDirectory = Application.StartupPath;
                            string imagesDirectory = Path.Combine(appDirectory, "Images");

                            if (!Directory.Exists(imagesDirectory))
                                Directory.CreateDirectory(imagesDirectory);

                            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(filename);
                            string uniqueDestPath = Path.Combine(imagesDirectory, uniqueFileName);

                            
                            File.Copy(filename, uniqueDestPath, true);

                            byte[] imageBytes = File.ReadAllBytes(uniqueDestPath);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                using (Image tempImg = Image.FromStream(ms))
                                {
                                    Image originalImage = (Image)tempImg.Clone();
                                    Image thumbnailImage = ResizeImage(originalImage, new Size(200, 100));

                                    imageList1.Images.Add(thumbnailImage);
                                    listView1.Items.Add(new ListViewItem
                                    {
                                        ImageIndex = imageList1.Images.Count - 1,
                                        Tag = new PatientImage
                                        {
                                            ImagePath = uniqueDestPath,
                                            OriginalImage = originalImage
                                        }
                                    });
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error importing image: {ex.Message}",
                                            "Import Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }



        private Image ResizeImage(Image image, Size size)
        {
            Bitmap resizedImage = new Bitmap(size.Width, size.Height);
            using (Graphics gfx = Graphics.FromImage(resizedImage))
            {
                gfx.DrawImage(image, new Rectangle(Point.Empty, size));
            }
            return resizedImage;
        }

        private void delete_image_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                ListViewItem selectedItem = listView1.Items[selectedIndex];
                var patientImage = selectedItem.Tag as PatientImage;
                if (patientImage != null)
                {
                    try
                    {
                        patientImage.OriginalImage?.Dispose();

                        if (File.Exists(patientImage.ImagePath))
                        {
                            File.Delete(patientImage.ImagePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting image file: {ex.Message}",
                                        "Deletion Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;                                                                                      //DO NOT RETURN
                    }

                    listView1.Items.RemoveAt(selectedIndex);
                    imageList1.Images.RemoveAt(selectedIndex);

                    for (int i = selectedIndex; i < listView1.Items.Count; i++)
                    {
                        listView1.Items[i].ImageIndex = i;
                    }

                    pictureBoxPreview.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Please select an image to delete.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addPatient_Load(object sender, EventArgs e)
        {

        }

        private void field_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_email_TextChanged(object sender, EventArgs e)
        {


        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }




        private void field_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void allergies_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void treated_formula_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void save_patient_data_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(field_name.Text) ||
                string.IsNullOrWhiteSpace(field_surname.Text) ||
                string.IsNullOrWhiteSpace(field_phone.Text) ||
                string.IsNullOrWhiteSpace(allergies_field.Text) ||
                !IsValidEmail(field_email.Text))
            {
                MessageBox.Show("Please check your inputs. Ensure all fields are filled correctly.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool isNewPatient = string.IsNullOrEmpty(txtPatientId.Text);

            int patientId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command;
                string patientQuery;

                if (isNewPatient)
                {
                    patientQuery =
                       "INSERT INTO Patients (Name, Surname, Phone, Email, Gender, DOB, Allergies, Treated) " +
                       "OUTPUT INSERTED.PatientID " +
                       "VALUES (@Name, @Surname, @Phone, @Email, @Gender, @DOB, @Allergies, @Treated)";

                    command = new SqlCommand(patientQuery, connection);

                    command.Parameters.AddWithValue("@DOB", DOB.Value);

                    command.Parameters.AddWithValue("@Name", field_name.Text);
                    command.Parameters.AddWithValue("@Surname", field_surname.Text);
                    command.Parameters.AddWithValue("@Phone", field_phone.Text);
                    command.Parameters.AddWithValue("@Email", field_email.Text);
                    command.Parameters.AddWithValue("@Gender", field_gender.SelectedItem?.ToString() ?? "");
                    command.Parameters.AddWithValue("@Allergies", allergies_field.Text);
                    command.Parameters.AddWithValue("@Treated", treated_formula.Text);

                    patientId = (int)command.ExecuteScalar();

                    txtPatientId.Text = patientId.ToString();
                }
                else
                {
                    patientQuery =
                        "UPDATE Patients " +
                        "SET Name = @Name, Surname = @Surname, Phone = @Phone, Email = @Email, " +
                        "    Gender = @Gender, Allergies = @Allergies, Treated = @Treated " +
                        "WHERE PatientID = @PatientID";

                    command = new SqlCommand(patientQuery, connection);

                    command.Parameters.AddWithValue("@PatientID", Convert.ToInt32(txtPatientId.Text));

                    command.Parameters.AddWithValue("@Name", field_name.Text);
                    command.Parameters.AddWithValue("@Surname", field_surname.Text);
                    command.Parameters.AddWithValue("@Phone", field_phone.Text);
                    command.Parameters.AddWithValue("@Email", field_email.Text);
                    command.Parameters.AddWithValue("@Gender", field_gender.SelectedItem?.ToString() ?? "");
                    command.Parameters.AddWithValue("@Allergies", allergies_field.Text);
                    command.Parameters.AddWithValue("@Treated", treated_formula.Text);

                    command.ExecuteNonQuery();

                    patientId = Convert.ToInt32(txtPatientId.Text);

                    
                    var delOldImagesCmd = new SqlCommand("DELETE FROM PatientImages WHERE PatientID = @pid", connection);
                    delOldImagesCmd.Parameters.AddWithValue("@pid", patientId);
                    delOldImagesCmd.ExecuteNonQuery();
                }

                
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Tag is PatientImage patientImage)
                    {
                        string imagePath = patientImage.ImagePath;

                        var imgCmd = new SqlCommand(
                            "INSERT INTO PatientImages (PatientID, ImagePath) VALUES (@pid, @path)",
                            connection
                        );
                        imgCmd.Parameters.AddWithValue("@pid", patientId);
                        imgCmd.Parameters.AddWithValue("@path", imagePath);
                        imgCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Patient data and images saved successfully.",
                            "Save Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MainForm parent = this.FindForm() as MainForm;
            if (parent != null)
            {
                parent.ShowPatients();
            }
        }







       

        private void delete_patient_data_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all data for this patient, including images?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtPatientId.Text) && int.TryParse(txtPatientId.Text, out int patientId))
                {
                    bool success = DeletePatient(patientId);
                    if (success)
                    {
                        clear_fields_addP_Click(this, EventArgs.Empty);
                        imageList1.Images.Clear();
                        listView1.Items.Clear();
                        pictureBoxPreview.Image = null;
                        txtPatientId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid or missing patient ID.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool DeletePatient(int patientId)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                   
                    List<string> imagePaths = new List<string>();

                    string selectImages = "SELECT ImagePath FROM PatientImages WHERE PatientID = @pid";
                    using (SqlCommand cmdSelectImages = new SqlCommand(selectImages, connection))
                    {
                        cmdSelectImages.Parameters.AddWithValue("@pid", patientId);
                        using (SqlDataReader readerImages = cmdSelectImages.ExecuteReader())
                        {
                            while (readerImages.Read())
                            {
                                string imagePath = readerImages["ImagePath"].ToString();
                                imagePaths.Add(imagePath);
                            }
                        }
                    }

                    string deleteImagesSql = "DELETE FROM PatientImages WHERE PatientID = @pid";
                    using (SqlCommand cmdDeleteImages = new SqlCommand(deleteImagesSql, connection))
                    {
                        cmdDeleteImages.Parameters.AddWithValue("@pid", patientId);
                        cmdDeleteImages.ExecuteNonQuery();
                    }

                   
                    foreach (var path in imagePaths)
                    {
                        if (File.Exists(path))
                        {
                            try
                            {
                                File.Delete(path);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error deleting file '{path}': {ex.Message}",
                                                "File Deletion Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                        }
                    }

                    string deletePatientSql = "DELETE FROM Patients WHERE PatientID = @pid";
                    using (SqlCommand cmdDeletePatient = new SqlCommand(deletePatientSql, connection))
                    {
                        cmdDeletePatient.Parameters.AddWithValue("@pid", patientId);
                        int rowsAffected = cmdDeletePatient.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            success = true;
                            MessageBox.Show("Patient deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No patient found with that ID.",
                                            "Deletion Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                lblStatus.Text = "Error deleting patient: " + ex.Message;
            }
            return success;
        }




        private void DeletePatientImages(int patientId, SqlConnection connection)
        {
            string deleteImagesQuery = "DELETE FROM PatientImages WHERE PatientID = @PatientId";
            using (SqlCommand imgCommand = new SqlCommand(deleteImagesQuery, connection))
            {
                imgCommand.Parameters.AddWithValue("@PatientId", patientId);
                imgCommand.ExecuteNonQuery();  
            }
        }



        private void clear_fields_addP_Click(object sender, EventArgs e)
        {
            field_name.Text = "";
            field_surname.Text = "";
            field_phone.Text = "";
            field_email.Text = "";
            allergies_field.Text = "";
            treated_formula.Text = "";

            field_gender.SelectedIndex = -1;  

            DOB.Value = DateTime.Now;  

        }




        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gender_addP_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm parent = this.FindForm() as MainForm;
            if (parent != null)
            {
                parent.ShowPatients();
            }
        }


        public class PatientImage
        {
            public string ImagePath { get; set; }
            public Image OriginalImage { get; set; }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {

        }
    }
}
