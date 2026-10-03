namespace DENTAL
{
    partial class addDentists
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            save_dentist_data = new Button();
            delete_dentist_data = new Button();
            panel2 = new Panel();
            delete_image = new Button();
            imort_Image = new Button();
            label7 = new Label();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            label8 = new Label();
            pictureBoxPreview = new PictureBox();
            lblStatus = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            clear_fields_addD = new Button();
            DOB = new DateTimePicker();
            field_gender = new ComboBox();
            label6 = new Label();
            gender_addD = new Label();
            label5 = new Label();
            txtDentistID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            name_addD = new Label();
            speciality_of_doctor = new TextBox();
            field_email = new TextBox();
            field_phone = new TextBox();
            field_surname = new TextBox();
            field_name = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // save_dentist_data
            // 
            save_dentist_data.BackColor = Color.FromArgb(0, 64, 64);
            save_dentist_data.ForeColor = Color.White;
            save_dentist_data.Location = new Point(790, 468);
            save_dentist_data.Name = "save_dentist_data";
            save_dentist_data.Size = new Size(75, 23);
            save_dentist_data.TabIndex = 2;
            save_dentist_data.Text = "SAVE";
            save_dentist_data.UseVisualStyleBackColor = false;
            save_dentist_data.Click += save_dentist_data_Click;
            // 
            // delete_dentist_data
            // 
            delete_dentist_data.BackColor = Color.FromArgb(0, 64, 64);
            delete_dentist_data.ForeColor = Color.White;
            delete_dentist_data.Location = new Point(720, 468);
            delete_dentist_data.Name = "delete_dentist_data";
            delete_dentist_data.Size = new Size(55, 23);
            delete_dentist_data.TabIndex = 3;
            delete_dentist_data.Text = "DELETE";
            delete_dentist_data.UseVisualStyleBackColor = false;
            delete_dentist_data.Click += delete_dentist_data_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(delete_image);
            panel2.Controls.Add(imort_Image);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBoxPreview);
            panel2.Controls.Add(lblStatus);
            panel2.Location = new Point(296, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 452);
            panel2.TabIndex = 4;
            // 
            // delete_image
            // 
            delete_image.BackColor = Color.FromArgb(0, 64, 64);
            delete_image.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_image.ForeColor = Color.White;
            delete_image.Location = new Point(93, 426);
            delete_image.Name = "delete_image";
            delete_image.Size = new Size(90, 23);
            delete_image.TabIndex = 0;
            delete_image.Text = "DELETE  Image";
            delete_image.UseVisualStyleBackColor = false;
            delete_image.Click += delete_image_Click;
            // 
            // imort_Image
            // 
            imort_Image.BackColor = Color.FromArgb(0, 64, 64);
            imort_Image.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imort_Image.ForeColor = Color.White;
            imort_Image.Location = new Point(3, 426);
            imort_Image.Name = "imort_Image";
            imort_Image.Size = new Size(84, 23);
            imort_Image.TabIndex = 0;
            imort_Image.Text = "Import Image";
            imort_Image.UseVisualStyleBackColor = false;
            imort_Image.Click += imort_Image_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(1, 2);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 3;
            label7.Text = "Dentist Images";
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(565, 171);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(100, 50);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(1, 171);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 3;
            label8.Text = "Analyze Image";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(0, 171);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(563, 281);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview.TabIndex = 2;
            pictureBoxPreview.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 272);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(clear_fields_addD);
            panel1.Controls.Add(DOB);
            panel1.Controls.Add(field_gender);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(gender_addD);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDentistID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(name_addD);
            panel1.Controls.Add(speciality_of_doctor);
            panel1.Controls.Add(field_email);
            panel1.Controls.Add(field_phone);
            panel1.Controls.Add(field_surname);
            panel1.Controls.Add(field_name);
            panel1.Location = new Point(14, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 452);
            panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 64, 64);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 22);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "BACK";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // clear_fields_addD
            // 
            clear_fields_addD.BackColor = Color.FromArgb(0, 64, 64);
            clear_fields_addD.ForeColor = Color.White;
            clear_fields_addD.Location = new Point(2, 428);
            clear_fields_addD.Name = "clear_fields_addD";
            clear_fields_addD.Size = new Size(57, 23);
            clear_fields_addD.TabIndex = 0;
            clear_fields_addD.Text = "CLEAR ";
            clear_fields_addD.UseVisualStyleBackColor = false;
            clear_fields_addD.Click += clear_fields_addD_Click;
            // 
            // DOB
            // 
            DOB.Location = new Point(67, 235);
            DOB.Name = "DOB";
            DOB.Size = new Size(190, 23);
            DOB.TabIndex = 4;
            DOB.ValueChanged += DOB_ValueChanged;
            // 
            // field_gender
            // 
            field_gender.FormattingEnabled = true;
            field_gender.Items.AddRange(new object[] { "Male", "Female" });
            field_gender.Location = new Point(68, 195);
            field_gender.Name = "field_gender";
            field_gender.Size = new Size(121, 23);
            field_gender.TabIndex = 2;
            field_gender.SelectedIndexChanged += field_gender_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(17, 235);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 1;
            label6.Text = "DOB";
            // 
            // gender_addD
            // 
            gender_addD.AutoSize = true;
            gender_addD.ForeColor = Color.Black;
            gender_addD.Location = new Point(15, 198);
            gender_addD.Name = "gender_addD";
            gender_addD.Size = new Size(45, 15);
            gender_addD.TabIndex = 1;
            gender_addD.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 287);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 1;
            label5.Text = "Speciality";
            // 
            // txtDentistID
            // 
            txtDentistID.BackColor = Color.White;
            txtDentistID.Location = new Point(0, 0);
            txtDentistID.Name = "txtDentistID";
            txtDentistID.Size = new Size(17, 23);
            txtDentistID.TabIndex = 4;
            txtDentistID.Visible = false;
            txtDentistID.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 156);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 116);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 71);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Surname";
            // 
            // name_addD
            // 
            name_addD.AutoSize = true;
            name_addD.ForeColor = Color.Black;
            name_addD.Location = new Point(15, 34);
            name_addD.Name = "name_addD";
            name_addD.Size = new Size(39, 15);
            name_addD.TabIndex = 1;
            name_addD.Text = "Name";
            // 
            // speciality_of_doctor
            // 
            speciality_of_doctor.Location = new Point(69, 284);
            speciality_of_doctor.Multiline = true;
            speciality_of_doctor.Name = "speciality_of_doctor";
            speciality_of_doctor.Size = new Size(198, 132);
            speciality_of_doctor.TabIndex = 0;
            speciality_of_doctor.TextChanged += speciality_of_doctor_TextChanged;
            // 
            // field_email
            // 
            field_email.Location = new Point(69, 153);
            field_email.Name = "field_email";
            field_email.Size = new Size(121, 23);
            field_email.TabIndex = 0;
            field_email.TextChanged += field_email_TextChanged;
            // 
            // field_phone
            // 
            field_phone.Location = new Point(69, 113);
            field_phone.Name = "field_phone";
            field_phone.Size = new Size(121, 23);
            field_phone.TabIndex = 0;
            field_phone.TextChanged += field_phone_TextChanged;
            // 
            // field_surname
            // 
            field_surname.Location = new Point(68, 68);
            field_surname.Name = "field_surname";
            field_surname.Size = new Size(121, 23);
            field_surname.TabIndex = 0;
            field_surname.TextChanged += field_surname_TextChanged;
            // 
            // field_name
            // 
            field_name.Location = new Point(68, 26);
            field_name.Name = "field_name";
            field_name.Size = new Size(121, 23);
            field_name.TabIndex = 0;
            field_name.TextChanged += field_name_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // addDentists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources.HD_wallpaper_dentist_neon_icon_blue_background_neon_symbols_dentist_neon_icons_dentist_sign_medical_signs_dentist_icon_medical_icons2;
            Controls.Add(save_dentist_data);
            Controls.Add(delete_dentist_data);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addDentists";
            Size = new Size(879, 500);
            Load += addDentists_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button save_dentist_data;
        private Button delete_dentist_data;
        private Panel panel2;
        private Label lblStatus;
        private Label label8;
        private Label label7;
        private ListView listView1;
        private Button imort_Image;
        private Button delete_image;
        private PictureBox pictureBoxPreview;
        private Panel panel1;
        private Button btnCancel;
        private Button clear_fields_addD;
        private DateTimePicker DOB;
        private ComboBox field_gender;
        private Label label6;
        private Label gender_addD;
        private Label label5;
        private TextBox txtDentistID;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label name_addD;
        private TextBox speciality_of_doctor;
        private TextBox allergies_field; 
        private TextBox field_email;
        private TextBox field_phone;
        private TextBox field_surname;
        private TextBox field_name;
        private OpenFileDialog openFileDialog1;
        private ImageList imageList1;
    }
}
