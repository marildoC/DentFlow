namespace DENTAL
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            button2 = new Button();
            button1 = new Button();
            register_Btn = new Button();
            register_loginBtn = new Button();
            register_confirmPassword = new TextBox();
            password_CR = new Label();
            register_username = new TextBox();
            username_R = new Label();
            password_R = new Label();
            register_password = new TextBox();
            button5 = new Button();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.rsz_2eye;
            button2.Location = new Point(457, 418);
            button2.Name = "button2";
            button2.Size = new Size(21, 19);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.rsz_3eye;
            button1.Location = new Point(457, 418);
            button1.Name = "button1";
            button1.Size = new Size(21, 19);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // register_Btn
            // 
            register_Btn.BackColor = Color.FromArgb(0, 64, 64);
            register_Btn.ForeColor = Color.Transparent;
            register_Btn.Location = new Point(361, 446);
            register_Btn.Name = "register_Btn";
            register_Btn.Size = new Size(117, 24);
            register_Btn.TabIndex = 10;
            register_Btn.Text = "SIGN UP";
            register_Btn.UseVisualStyleBackColor = false;
            register_Btn.Click += register_Btn_Click;
            // 
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.FromArgb(0, 64, 64);
            register_loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = Color.White;
            register_loginBtn.Location = new Point(636, 444);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(140, 30);
            register_loginBtn.TabIndex = 11;
            register_loginBtn.Text = "Log In";
            register_loginBtn.UseVisualStyleBackColor = false;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // register_confirmPassword
            // 
            register_confirmPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_confirmPassword.Location = new Point(361, 418);
            register_confirmPassword.Name = "register_confirmPassword";
            register_confirmPassword.PasswordChar = '*';
            register_confirmPassword.Size = new Size(117, 22);
            register_confirmPassword.TabIndex = 8;
            register_confirmPassword.TextChanged += register_confirmPassword_TextChanged;
            // 
            // password_CR
            // 
            password_CR.AutoSize = true;
            password_CR.BackColor = Color.Teal;
            password_CR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_CR.ForeColor = Color.White;
            password_CR.Location = new Point(254, 422);
            password_CR.Name = "password_CR";
            password_CR.Size = new Size(104, 15);
            password_CR.TabIndex = 6;
            password_CR.Text = "Confirm Password\r\n";
            // 
            // register_username
            // 
            register_username.BackColor = SystemColors.Window;
            register_username.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.ForeColor = SystemColors.WindowText;
            register_username.Location = new Point(361, 357);
            register_username.Name = "register_username";
            register_username.Size = new Size(117, 22);
            register_username.TabIndex = 9;
            // 
            // username_R
            // 
            username_R.AutoSize = true;
            username_R.BackColor = Color.Teal;
            username_R.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_R.ForeColor = Color.White;
            username_R.Location = new Point(299, 361);
            username_R.Name = "username_R";
            username_R.Size = new Size(60, 15);
            username_R.TabIndex = 7;
            username_R.Text = "Username";
            // 
            // password_R
            // 
            password_R.AutoSize = true;
            password_R.BackColor = Color.Teal;
            password_R.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_R.ForeColor = Color.White;
            password_R.Location = new Point(301, 394);
            password_R.Name = "password_R";
            password_R.Size = new Size(57, 15);
            password_R.TabIndex = 6;
            password_R.Text = "Password";
            // 
            // register_password
            // 
            register_password.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(361, 390);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(117, 22);
            register_password.TabIndex = 8;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.rsz_3eye;
            button5.Location = new Point(457, 390);
            button5.Name = "button5";
            button5.Size = new Size(21, 19);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.rsz_2eye;
            button4.Location = new Point(457, 390);
            button4.Name = "button4";
            button4.Size = new Size(21, 19);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(636, 428);
            label3.Name = "label3";
            label3.Size = new Size(140, 13);
            label3.TabIndex = 14;
            label3.Text = "Already Have An Account?\r\n";
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(788, 479);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(register_Btn);
            Controls.Add(register_loginBtn);
            Controls.Add(register_password);
            Controls.Add(password_R);
            Controls.Add(register_confirmPassword);
            Controls.Add(password_CR);
            Controls.Add(register_username);
            Controls.Add(username_R);
            Name = "registerForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Dental Clinic";
            Load += registerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button register_Btn;
        private Button register_loginBtn;
        private TextBox register_confirmPassword;
        private Label password_CR;
        private TextBox register_username;
        private Label username_R;
        private Label password_R;
        private TextBox register_password;
        private Button button5;
        private Button button4;
        private Label label3;
    }
}