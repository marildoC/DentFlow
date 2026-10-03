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
    public partial class registerForm : Form
    {
       
        private int originalFormWidth;
        private int originalFormHeight;
        private Dictionary<Control, Rectangle> controlOriginalDimensions; 

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";
                                   

        public registerForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 600); 

            
            originalFormWidth = this.Width;
            originalFormHeight = this.Height;
            controlOriginalDimensions = new Dictionary<Control, Rectangle>();

            foreach (Control control in this.Controls)
            {
                controlOriginalDimensions[control] = new Rectangle(control.Location, control.Size);
            }

            this.Resize += new EventHandler(Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            float widthRatio = (float)this.Width / originalFormWidth;
            float heightRatio = (float)this.Height / originalFormHeight;

            foreach (var control in controlOriginalDimensions)
            {
                Control ctrl = control.Key;
                Rectangle originalRect = control.Value;

                int newX = (int)(originalRect.X * widthRatio);
                int newY = (int)(originalRect.Y * heightRatio);
                int newWidth = (int)(originalRect.Width * widthRatio);
                int newHeight = (int)(originalRect.Height * heightRatio);

                ctrl.SetBounds(newX, newY, newWidth, newHeight);
            }
        }






        private void registerForm_Load(object sender, EventArgs e)
        {
        }

        private void close_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (register_confirmPassword.PasswordChar == '*')
            {
                button1.BringToFront();
                register_confirmPassword.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (register_confirmPassword.PasswordChar == '\0') 
            {
                button2.BringToFront();
                register_confirmPassword.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (register_password.PasswordChar == '*')
            {
                button5.BringToFront();
                register_password.PasswordChar = '\0';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (register_password.PasswordChar == '\0')
            {
                button4.BringToFront();
                register_password.PasswordChar = '*';
            }
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {

            Form1 loginForm1 = new Form1();
            loginForm1.Show();

            loginForm1.Size = this.Size;

            loginForm1.StartPosition = FormStartPosition.Manual;
            loginForm1.Location = this.Location;

            this.Hide();
        }

        private void register_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(register_username.Text) ||
                string.IsNullOrWhiteSpace(register_password.Text) ||
                string.IsNullOrWhiteSpace(register_confirmPassword.Text))
            {
                MessageBox.Show("Fields are empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(register_username.Text.Trim(), @"^[a-zA-Z0-9_]{3,30}$"))
            {
                MessageBox.Show("Username must be alphanumeric and between 3-30 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkUsernQuery = "SELECT COUNT(*) FROM users WHERE username = @usern";
                using (SqlCommand checkUsern = new SqlCommand(checkUsernQuery, connection)) 
                {
                    checkUsern.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                    int userCount = Convert.ToInt32(checkUsern.ExecuteScalar());

                    if (userCount > 0)
                    {
                        string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                        MessageBox.Show(tempUsern + " is already existing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (register_password.Text.Length < 8)
                {
                    MessageBox.Show("Invalid password. At least 8 characters are required.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(register_password.Text, @"^(?=.*[A-Za-z])(?=.*\d).+$"))
                {
                    MessageBox.Show("Password must contain at least one letter and one number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (register_password.Text != register_confirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertData = "INSERT INTO users (username, password, role, status, date_register) " +
                                    "VALUES (@usern, @pass, @role, @status, @date)";
                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(register_password.Text.Trim());

                    cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", hashedPassword); 
                    cmd.Parameters.AddWithValue("@role", "TEAM");
                    cmd.Parameters.AddWithValue("@status", "Approval");
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    Form1 loginForm = new Form1(); 
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void register_confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
