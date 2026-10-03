namespace DENTAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username_L = new Label();
            login_username = new TextBox();
            Password_L = new Label();
            login_password = new TextBox();
            login_btn = new Button();
            register_button = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Username_L
            // 
            Username_L.AutoSize = true;
            Username_L.BackColor = Color.Teal;
            Username_L.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_L.ForeColor = Color.White;
            Username_L.Location = new Point(290, 365);
            Username_L.Name = "Username_L";
            Username_L.Size = new Size(60, 15);
            Username_L.TabIndex = 1;
            Username_L.Text = "Username";
            Username_L.Click += Username_L_Click;
            // 
            // login_username
            // 
            login_username.BackColor = SystemColors.Window;
            login_username.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.ForeColor = SystemColors.WindowText;
            login_username.Location = new Point(352, 360);
            login_username.Name = "login_username";
            login_username.Size = new Size(117, 22);
            login_username.TabIndex = 2;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // Password_L
            // 
            Password_L.AutoSize = true;
            Password_L.BackColor = Color.Teal;
            Password_L.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_L.ForeColor = Color.White;
            Password_L.Location = new Point(293, 387);
            Password_L.Name = "Password_L";
            Password_L.Size = new Size(57, 15);
            Password_L.TabIndex = 1;
            Password_L.Text = "Password";
            Password_L.Click += Password_L_Click;
            // 
            // login_password
            // 
            login_password.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(352, 385);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(117, 22);
            login_password.TabIndex = 2;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(0, 64, 64);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(359, 414);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(102, 23);
            login_btn.TabIndex = 3;
            login_btn.Text = "SIGN IN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // register_button
            // 
            register_button.BackColor = Color.FromArgb(0, 64, 64);
            register_button.ForeColor = Color.White;
            register_button.Location = new Point(687, 444);
            register_button.Name = "register_button";
            register_button.Size = new Size(75, 23);
            register_button.TabIndex = 3;
            register_button.Text = "REGISTER";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.rsz_3eye;
            button1.Location = new Point(450, 385);
            button1.Name = "button1";
            button1.Size = new Size(19, 19);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.rsz_2eye;
            button2.Location = new Point(448, 385);
            button2.Name = "button2";
            button2.Size = new Size(21, 19);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.HD_wallpaper_dentist_neon_icon_blue_background_neon_symbols_dentist_neon_icons_dentist_sign_medical_signs_dentist_icon_medical_icons7;
            ClientSize = new Size(788, 479);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(login_btn);
            Controls.Add(register_button);
            Controls.Add(login_password);
            Controls.Add(Password_L);
            Controls.Add(login_username);
            Controls.Add(Username_L);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Dental Clinic";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Username_L;  
        private TextBox login_username;
        private Label Password_L;
        private TextBox login_password;
        private Button login_btn;
        private Button register_button;
        private Button button1;
        private Button button2;
    }
}
