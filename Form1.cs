
using System.Data;
using Microsoft.Data.SqlClient;

namespace DENTAL
{
    public partial class Form1 : Form
    {
        private int originalFormWidth; 
        private int originalFormHeight;
        private Dictionary<Control, Rectangle> controlOriginalDimensions;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1() 
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







        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Username_L_Click(object sender, EventArgs e)
        {


        }
        private void Password_L_Click(object sender, EventArgs e)
        {


        }

        private void close_app_Click(object sender, EventArgs e)

        {
            Application.Exit();

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e) 
        {
            if(login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Empty Fields!!!" , "Error Message" , MessageBoxButtons.OK , MessageBoxIcon.Error);


            } else
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); 


                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";  
                    using(SqlCommand cmd = new SqlCommand(selectData , connection))
                    {
                        cmd.Parameters.AddWithValue("@usern" ,login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim()); 

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table); 

                        if(table.Rows.Count > 0)
                        {
                            
                            MainForm mForm = new MainForm();
                            mForm.Show();

                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password / or you need premission from ADMIN", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        }

                    }
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (login_password.PasswordChar == '*')
            {
                button1.BringToFront();
                login_password.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_password.PasswordChar == '\0')
            {
                button2.BringToFront();
                login_password.PasswordChar = '*';
            }

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            registerForm regform = new registerForm();
            regform.Show();

           
            regform.Size = this.Size;

            regform.StartPosition = FormStartPosition.Manual;
            regform.Location = this.Location; 


            this.Hide();   
        }
    }
}
