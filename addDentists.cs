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
    public partial class addDentists : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        public addDentists()
        {
            InitializeComponent();

            imageList1.ImageSize = new Size(200, 100);


        }

        public void SetDentistDetails(string name, string surname, string phone, string email, string gender, DateTime dob, string specialty)
        {
            field_name.Text = name;
            field_surname.Text = surname;
            field_phone.Text = phone;
            field_email.Text = email;
            field_gender.SelectedItem = gender;
            DOB.Value = dob;
            speciality_of_doctor.Text = specialty;
        }



        public void LoadDentistData(int dentistId)
        {
            if (dentistId == 0)
            {
                clear_fields_addD_Click(this, EventArgs.Empty);
                txtDentistID.Text = "";  

                imageList1.Images.Clear(); 
                listView1.Items.Clear();
                pictureBoxPreview.Image = null; 
            }
            else 
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Name, Surname, Phone, Email, Gender, DOB, Specialty
                                     FROM Dentists 
                                     WHERE DentistID = @DentistID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DentistID", dentistId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SetDentistDetails(
                                    reader["Name"].ToString(),
                                    reader["Surname"].ToString(),
                                    reader["Phone"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Gender"].ToString(),
                                    (DateTime)reader["DOB"],
                                    reader["Specialty"].ToString()
                                );

                                txtDentistID.Text = dentistId.ToString();
                            }
                        }
                    }

                    string imagesQuery = @"SELECT ImagePath FROM DentistImages WHERE DentistID = @DentistID";
                    using (SqlCommand cmdImages = new SqlCommand(imagesQuery, conn))
                    {
                        cmdImages.Parameters.AddWithValue("@DentistID", dentistId);

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
                                                    Tag = new DentistImage
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
                                        MessageBox.Show("Error loading image: " + ex.Message,
                                                        "Image Load Error",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Error);
                                    }
                                }
                            }

                            pictureBoxPreview.Image = null;
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

        private void imort_Image_Click(object sender, EventArgs e)
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
                                        Tag = new DentistImage
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
                            MessageBox.Show("Error importing image: " + ex.Message,
                                            "Import Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void delete_image_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                var selectedItem = listView1.Items[selectedIndex];
                var dentistImage = selectedItem.Tag as DentistImage;
                if (dentistImage != null)
                {
                    try
                    {
                        dentistImage.OriginalImage?.Dispose();
                        if (File.Exists(dentistImage.ImagePath))
                        {
                            File.Delete(dentistImage.ImagePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting image file: " + ex.Message,
                                        "Deletion Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                var dentistImage = selectedItem.Tag as DentistImage;
                if (dentistImage != null)
                {
                    pictureBoxPreview.Image = dentistImage.OriginalImage;
                }
            }
            else
            {
                pictureBoxPreview.Image = null;
            }
        }


        private void clear_fields_addD_Click(object sender, EventArgs e)
        {
            field_name.Text = "";
            field_surname.Text = "";
            field_phone.Text = "";
            field_email.Text = "";
            field_gender.SelectedIndex = -1;
            DOB.Value = DateTime.Now;
            speciality_of_doctor.Text = "";

            listView1.Items.Clear();
            imageList1.Images.Clear();
            pictureBoxPreview.Image = null;

            txtDentistID.Text = "";
        }


        private void save_dentist_data_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(field_name.Text) ||
                string.IsNullOrWhiteSpace(field_surname.Text) ||
                string.IsNullOrWhiteSpace(field_phone.Text) ||
                string.IsNullOrWhiteSpace(field_email.Text))
            {
                MessageBox.Show("Please check your inputs. Some required fields are empty.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool isNewDentist = string.IsNullOrWhiteSpace(txtDentistID.Text);
            int dentistId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command;
                string dentistQuery;

                if (isNewDentist)
                {
                   
                    dentistQuery = @"
                INSERT INTO Dentists
                    (Name, Surname, Phone, Email, Gender, DOB, Specialty)
                OUTPUT INSERTED.DentistID
                VALUES
                    (@Name, @Surname, @Phone, @Email, @Gender, @DOB, @Specialty)";

                    command = new SqlCommand(dentistQuery, connection);

                    command.Parameters.AddWithValue("@DOB", DOB.Value);
                }
                else
                {
                    dentistQuery = @"
                UPDATE Dentists
                   SET Name      = @Name,
                       Surname   = @Surname,
                       Phone     = @Phone,
                       Email     = @Email,
                       Gender    = @Gender,
                       DOB       = @DOB,
                       Specialty = @Specialty
                 WHERE DentistID = @DentistID";

                    command = new SqlCommand(dentistQuery, connection);

                    command.Parameters.AddWithValue("@DentistID", Convert.ToInt32(txtDentistID.Text));

                    command.Parameters.AddWithValue("@DOB", DOB.Value);
                }

                command.Parameters.AddWithValue("@Name", field_name.Text);
                command.Parameters.AddWithValue("@Surname", field_surname.Text);
                command.Parameters.AddWithValue("@Phone", field_phone.Text);
                command.Parameters.AddWithValue("@Email", field_email.Text);
                command.Parameters.AddWithValue("@Gender", field_gender.SelectedItem?.ToString() ?? "");
                command.Parameters.AddWithValue("@Specialty", speciality_of_doctor.Text);

                if (isNewDentist)
                {
                    dentistId = (int)command.ExecuteScalar();
                    txtDentistID.Text = dentistId.ToString();
                }
                else
                {
                    command.ExecuteNonQuery();

                    dentistId = Convert.ToInt32(txtDentistID.Text);

                    string delOldImagesSql = "DELETE FROM DentistImages WHERE DentistID = @did";
                    using (SqlCommand cmdDel = new SqlCommand(delOldImagesSql, connection))
                    {
                        cmdDel.Parameters.AddWithValue("@did", dentistId);
                        cmdDel.ExecuteNonQuery();
                    }
                }

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Tag is DentistImage di)
                    {
                        var imagePath = di.ImagePath;

                        var imgCmd = new SqlCommand(@"
                    INSERT INTO DentistImages (DentistID, ImagePath)
                    VALUES (@did, @path)",
                            connection
                        );

                        imgCmd.Parameters.AddWithValue("@did", dentistId);
                        imgCmd.Parameters.AddWithValue("@path", imagePath);
                        imgCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Dentist data saved successfully!",
                            "Save Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MainForm parent = this.FindForm() as MainForm;
            if (parent != null)
            {
                parent.ShowDentists(); 
            } 
        }


        private void delete_dentist_data_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(txtDentistID.Text, out int dentistId) || dentistId <= 0)
            {
                MessageBox.Show("Invalid dentist ID.");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this dentist (and images)?",
                                              "Confirm Deletion",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DeleteDentist(dentistId);
                clear_fields_addD_Click(this, EventArgs.Empty);
            }
        }

        
        private bool DeleteDentist(int dentistId)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    List<string> imagePaths = new List<string>();
                    string selectImgs = "SELECT ImagePath FROM DentistImages WHERE DentistID = @did";
                    using (SqlCommand scmd = new SqlCommand(selectImgs, connection))
                    {
                        scmd.Parameters.AddWithValue("@did", dentistId);
                        using (SqlDataReader r = scmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                imagePaths.Add(r["ImagePath"].ToString());
                            }
                        }
                    }

                    string delImgs = "DELETE FROM DentistImages WHERE DentistID = @did";
                    using (SqlCommand delCmd = new SqlCommand(delImgs, connection))
                    {
                        delCmd.Parameters.AddWithValue("@did", dentistId);
                        delCmd.ExecuteNonQuery();
                    }

                    foreach (string path in imagePaths)
                    {
                        if (File.Exists(path))
                        {
                            try { File.Delete(path); }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting file: " + ex.Message,
                                                "File Deletion Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                        }
                    }

                    string delDentist = "DELETE FROM Dentists WHERE DentistID = @did";
                    using (SqlCommand cmdD = new SqlCommand(delDentist, connection))
                    {
                        cmdD.Parameters.AddWithValue("@did", dentistId);
                        int rows = cmdD.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            success = true;
                            MessageBox.Show("Dentist record deleted.");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting dentist: " + ex.Message,
                                "Deletion Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            return success;
        }

        public class DentistImage
        {
            public string ImagePath { get; set; }
            public Image OriginalImage { get; set; }
        }















        private void addDentists_Load(object sender, EventArgs e)
        {

        }

        private void field_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void field_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void speciality_of_doctor_TextChanged(object sender, EventArgs e)
        {

        }

       
        
        private void btnCancel_Click(object sender, EventArgs e)
        {

            MainForm parent = this.FindForm() as MainForm;
            if (parent != null)
            {
                parent.ShowDentists();  
            }

        }
    }
}
