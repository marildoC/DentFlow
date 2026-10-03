 namespace DENTAL
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); 
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dentist_bttn = new Button();
            pictureBox1 = new PictureBox();
            revenue_btt = new Button();
            button5 = new Button();
            button6 = new Button();
            dashboard_bttn = new Button();
            pictureBox4 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblClinicName = new Label();
            settings_bttn = new Button();
            patientss_bttn = new Button();
            appointements_button = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel2 = new Panel();
            addAppointement1 = new addAppointement();
            treatment1 = new Treatment();
            adminDashboard1 = new adminDashboard();
            addPatient1 = new addPatient();
            patients1 = new patients();
            addDentists1 = new addDentists();
            dentists1 = new dentists();
            appointments1 = new Appointments();
            revenues1 = new revenues();
            setting1 = new setting();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dentist_bttn
            // 
            dentist_bttn.BackColor = Color.Transparent;
            dentist_bttn.FlatAppearance.BorderSize = 0;
            dentist_bttn.FlatStyle = FlatStyle.Flat;
            dentist_bttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dentist_bttn.ForeColor = Color.White;
            dentist_bttn.Location = new Point(15, 235);
            dentist_bttn.Name = "dentist_bttn";
            dentist_bttn.Size = new Size(116, 25);
            dentist_bttn.TabIndex = 2;
            dentist_bttn.Text = "  Dentists";
            dentist_bttn.UseVisualStyleBackColor = false;
            dentist_bttn.Click += dentist_bttn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 77);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // revenue_btt
            // 
            revenue_btt.BackColor = Color.Transparent;
            revenue_btt.FlatAppearance.BorderSize = 0;
            revenue_btt.FlatStyle = FlatStyle.Flat;
            revenue_btt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            revenue_btt.ForeColor = Color.White;
            revenue_btt.Location = new Point(15, 338);
            revenue_btt.Name = "revenue_btt";
            revenue_btt.Size = new Size(116, 25);
            revenue_btt.TabIndex = 0;
            revenue_btt.Text = "  Revenue";
            revenue_btt.UseVisualStyleBackColor = false;
            revenue_btt.Click += revenue_btt_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(26, 488);
            button5.Name = "button5";
            button5.Size = new Size(116, 25);
            button5.TabIndex = 0;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(34, 77, 78);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(15, 610);
            button6.Name = "button6";
            button6.Size = new Size(116, 33);
            button6.TabIndex = 0;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            // 
            // dashboard_bttn
            // 
            dashboard_bttn.BackColor = Color.Transparent;
            dashboard_bttn.FlatAppearance.BorderSize = 0;
            dashboard_bttn.FlatStyle = FlatStyle.Flat;
            dashboard_bttn.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_bttn.ForeColor = Color.White;
            dashboard_bttn.Location = new Point(15, 136);
            dashboard_bttn.Name = "dashboard_bttn";
            dashboard_bttn.Size = new Size(116, 27);
            dashboard_bttn.TabIndex = 0;
            dashboard_bttn.Text = "     Dashboard";
            dashboard_bttn.UseVisualStyleBackColor = false;
            dashboard_bttn.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 444);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 27);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox2_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 187);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 27);
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 27);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox2_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 286);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(28, 30);
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 338);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 27);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(15, 488);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(lblClinicName);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(dashboard_bttn);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(settings_bttn);
            panel1.Controls.Add(revenue_btt);
            panel1.Controls.Add(patientss_bttn);
            panel1.Controls.Add(dentist_bttn);
            panel1.Controls.Add(appointements_button);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 521);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblClinicName
            // 
            lblClinicName.AutoSize = true;
            lblClinicName.BackColor = Color.DarkSlateGray;
            lblClinicName.Font = new Font("Imprint MT Shadow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicName.ForeColor = Color.White;
            lblClinicName.Location = new Point(30, 43);
            lblClinicName.Name = "lblClinicName";
            lblClinicName.Size = new Size(73, 30);
            lblClinicName.TabIndex = 3;
            lblClinicName.Text = "Name  Of \r\n Clinic\r\n";
            // 
            // settings_bttn
            // 
            settings_bttn.BackColor = Color.Transparent;
            settings_bttn.FlatAppearance.BorderSize = 0;
            settings_bttn.FlatStyle = FlatStyle.Flat;
            settings_bttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settings_bttn.ForeColor = Color.White;
            settings_bttn.Location = new Point(44, 446);
            settings_bttn.Name = "settings_bttn";
            settings_bttn.Size = new Size(85, 25);
            settings_bttn.TabIndex = 0;
            settings_bttn.Text = " Settings";
            settings_bttn.UseVisualStyleBackColor = false;
            settings_bttn.Click += settings_bttn_Click;
            // 
            // patientss_bttn
            // 
            patientss_bttn.BackColor = Color.Transparent;
            patientss_bttn.FlatAppearance.BorderSize = 0;
            patientss_bttn.FlatAppearance.MouseDownBackColor = Color.White;
            patientss_bttn.FlatStyle = FlatStyle.Flat;
            patientss_bttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientss_bttn.ForeColor = Color.White;
            patientss_bttn.Location = new Point(15, 189);
            patientss_bttn.Name = "patientss_bttn";
            patientss_bttn.Size = new Size(116, 25);
            patientss_bttn.TabIndex = 0;
            patientss_bttn.Text = "    Patients ";
            patientss_bttn.UseVisualStyleBackColor = false;
            patientss_bttn.Click += button2_Click;
            // 
            // appointements_button
            // 
            appointements_button.BackColor = Color.Transparent;
            appointements_button.FlatAppearance.BorderSize = 0;
            appointements_button.FlatStyle = FlatStyle.Flat;
            appointements_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointements_button.ForeColor = Color.White;
            appointements_button.Location = new Point(35, 288);
            appointements_button.Name = "appointements_button";
            appointements_button.Size = new Size(98, 26);
            appointements_button.TabIndex = 4;
            appointements_button.Text = "Appointments";
            appointements_button.UseVisualStyleBackColor = false;
            appointements_button.Click += appointements_button_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(addAppointement1);
            panel2.Controls.Add(treatment1);
            panel2.Controls.Add(adminDashboard1);
            panel2.Controls.Add(addPatient1);
            panel2.Controls.Add(patients1);
            panel2.Controls.Add(addDentists1);
            panel2.Controls.Add(dentists1);
            panel2.Controls.Add(appointments1);
            panel2.Controls.Add(revenues1);
            panel2.Controls.Add(setting1);
            panel2.Location = new Point(148, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 521);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // addAppointement1
            // 
            addAppointement1.BackgroundImage = (Image)resources.GetObject("addAppointement1.BackgroundImage");
            addAppointement1.Location = new Point(572, 12);
            addAppointement1.Name = "addAppointement1";
            addAppointement1.Size = new Size(302, 434);
            addAppointement1.TabIndex = 18;
            // 
            // treatment1
            // 
            treatment1.BackColor = Color.White;
            treatment1.BackgroundImage = (Image)resources.GetObject("treatment1.BackgroundImage");
            treatment1.Location = new Point(241, 12);
            treatment1.Name = "treatment1";
            treatment1.Size = new Size(633, 323);
            treatment1.TabIndex = 17;
            // 
            // adminDashboard1
            // 
            adminDashboard1.BackgroundImage = (Image)resources.GetObject("adminDashboard1.BackgroundImage");
            adminDashboard1.Location = new Point(0, 3);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(886, 518);
            adminDashboard1.TabIndex = 16;
            // 
            // addPatient1
            // 
            addPatient1.BackColor = Color.FromArgb(0, 64, 64);
            addPatient1.BackgroundImage = (Image)resources.GetObject("addPatient1.BackgroundImage");
            addPatient1.Location = new Point(1, -3);
            addPatient1.Name = "addPatient1";
            addPatient1.Size = new Size(886, 521);
            addPatient1.TabIndex = 15;
            // 
            // patients1
            // 
            patients1.BackgroundImage = (Image)resources.GetObject("patients1.BackgroundImage");
            patients1.Location = new Point(1, 0);
            patients1.Name = "patients1";
            patients1.Size = new Size(886, 521);
            patients1.TabIndex = 14;
            // 
            // addDentists1
            // 
            addDentists1.BackColor = Color.FromArgb(0, 64, 64);
            addDentists1.BackgroundImage = (Image)resources.GetObject("addDentists1.BackgroundImage");
            addDentists1.Location = new Point(0, 0);
            addDentists1.Name = "addDentists1";
            addDentists1.Size = new Size(886, 521);
            addDentists1.TabIndex = 13;
            // 
            // dentists1
            // 
            dentists1.BackgroundImage = (Image)resources.GetObject("dentists1.BackgroundImage");
            dentists1.Location = new Point(0, -3);
            dentists1.Name = "dentists1";
            dentists1.Size = new Size(886, 521);
            dentists1.TabIndex = 12;
            // 
            // appointments1
            // 
            appointments1.BackgroundImage = (Image)resources.GetObject("appointments1.BackgroundImage");
            appointments1.Location = new Point(0, 0);
            appointments1.Name = "appointments1";
            appointments1.Size = new Size(886, 521);
            appointments1.TabIndex = 2;
            // 
            // revenues1
            // 
            revenues1.BackColor = Color.White;
            revenues1.Location = new Point(0, 0);
            revenues1.Name = "revenues1";
            revenues1.Size = new Size(886, 521);
            revenues1.TabIndex = 1;
            // 
            // setting1
            // 
            setting1.BackColor = Color.White;
            setting1.BackgroundImage = (Image)resources.GetObject("setting1.BackgroundImage");
            setting1.Location = new Point(0, 0);
            setting1.Name = "setting1";
            setting1.Size = new Size(886, 521);
            setting1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dental System";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button dentist_bttn;
        private PictureBox pictureBox1;
        private Button revenue_btt;
        private Button button5;
        private Button button6;
        private Button dashboard_bttn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button settings_bttn;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private patientForm patientForm1;
        private Button patientss_bttn;
        private Panel panel2;
        private Label lblClinicName;
        private Button appointements_button;
        private Appointments appointments1;
        private revenues revenues1;
        private setting setting1;
        private addPatient addPatient1;
        private patients patients1;
        private addDentists addDentists1;
        private dentists dentists1;
        private adminDashboard adminDashboard1;
        private addAppointement addAppointement1;
        private Treatment treatment1;
    }
}