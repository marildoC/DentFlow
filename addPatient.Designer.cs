namespace DENTAL
{
    partial class addPatient
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
            delete_patient_data = new Button();
            panel1 = new Panel();
            btnCancel = new Button();
            clear_fields_addP = new Button();
            DOB = new DateTimePicker();
            field_gender = new ComboBox();
            label6 = new Label();
            gender_addP = new Label();
            label5 = new Label();
            txtPatientId = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            name_addP = new Label();
            treated_formula = new TextBox();
            allergies_field = new TextBox();
            field_email = new TextBox();
            field_phone = new TextBox();
            field_surname = new TextBox();
            field_name = new TextBox();
            lblStatus = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            imort_Image = new Button();
            delete_image = new Button();
            pictureBoxPreview = new PictureBox();
            save_patient_data = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // delete_patient_data
            // 
            delete_patient_data.BackColor = Color.FromArgb(0, 64, 64);
            delete_patient_data.ForeColor = Color.White;
            delete_patient_data.Location = new Point(722, 474);
            delete_patient_data.Name = "delete_patient_data";
            delete_patient_data.Size = new Size(55, 23);
            delete_patient_data.TabIndex = 0;
            delete_patient_data.Text = "DELETE";
            delete_patient_data.UseVisualStyleBackColor = false;
            delete_patient_data.Click += delete_patient_data_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(clear_fields_addP);
            panel1.Controls.Add(DOB);
            panel1.Controls.Add(field_gender);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(gender_addP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPatientId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(name_addP);
            panel1.Controls.Add(treated_formula);
            panel1.Controls.Add(allergies_field);
            panel1.Controls.Add(field_email);
            panel1.Controls.Add(field_phone);
            panel1.Controls.Add(field_surname);
            panel1.Controls.Add(field_name);
            panel1.Location = new Point(16, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 452);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 64, 64);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, -1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 22);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "BACK";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // clear_fields_addP
            // 
            clear_fields_addP.BackColor = Color.FromArgb(0, 64, 64);
            clear_fields_addP.ForeColor = Color.White;
            clear_fields_addP.Location = new Point(2, 428);
            clear_fields_addP.Name = "clear_fields_addP";
            clear_fields_addP.Size = new Size(57, 23);
            clear_fields_addP.TabIndex = 0;
            clear_fields_addP.Text = "CLEAR ";
            clear_fields_addP.UseVisualStyleBackColor = false;
            clear_fields_addP.Click += clear_fields_addP_Click;
            // 
            // DOB
            // 
            DOB.Location = new Point(67, 235);
            DOB.Name = "DOB";
            DOB.Size = new Size(200, 23);
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
            label6.Click += label6_Click;
            // 
            // gender_addP
            // 
            gender_addP.AutoSize = true;
            gender_addP.ForeColor = Color.Black;
            gender_addP.Location = new Point(15, 198);
            gender_addP.Name = "gender_addP";
            gender_addP.Size = new Size(45, 15);
            gender_addP.TabIndex = 1;
            gender_addP.Text = "Gender";
            gender_addP.Click += gender_addP_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(17, 342);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 1;
            label5.Text = "Treated";
            // 
            // txtPatientId
            // 
            txtPatientId.BackColor = Color.White;
            txtPatientId.Location = new Point(0, 0);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(17, 23);
            txtPatientId.TabIndex = 4;
            txtPatientId.Visible = false;
            txtPatientId.WordWrap = false;
            txtPatientId.TextChanged += txtPatientId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 272);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Allergies";
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
            // name_addP
            // 
            name_addP.AutoSize = true;
            name_addP.ForeColor = Color.Black;
            name_addP.Location = new Point(15, 34);
            name_addP.Name = "name_addP";
            name_addP.Size = new Size(39, 15);
            name_addP.TabIndex = 1;
            name_addP.Text = "Name";
            // 
            // treated_formula
            // 
            treated_formula.Location = new Point(69, 342);
            treated_formula.Multiline = true;
            treated_formula.Name = "treated_formula";
            treated_formula.Size = new Size(159, 79);
            treated_formula.TabIndex = 0;
            treated_formula.TextChanged += treated_formula_TextChanged;
            // 
            // allergies_field
            // 
            allergies_field.Location = new Point(68, 272);
            allergies_field.Multiline = true;
            allergies_field.Name = "allergies_field";
            allergies_field.Size = new Size(159, 53);
            allergies_field.TabIndex = 0;
            allergies_field.TextChanged += allergies_field_TextChanged;
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
            field_phone.TextChanged += field_number_TextChanged;
            // 
            // field_surname
            // 
            field_surname.Location = new Point(68, 68);
            field_surname.Name = "field_surname";
            field_surname.Size = new Size(121, 23);
            field_surname.TabIndex = 0;
            field_surname.TextChanged += field_username_TextChanged;
            // 
            // field_name
            // 
            field_name.Location = new Point(68, 26);
            field_name.Name = "field_name";
            field_name.Size = new Size(121, 23);
            field_name.TabIndex = 0;
            field_name.TextChanged += field_name_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 272);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Click += lblStatus_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(imort_Image);
            panel2.Controls.Add(delete_image);
            panel2.Controls.Add(pictureBoxPreview);
            panel2.Location = new Point(298, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 452);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(3, 165);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 3;
            label8.Text = "Analyze Image";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(2, 2);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 3;
            label7.Text = "Patient Images";
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(0, -1);
            listView1.Name = "listView1";
            listView1.Size = new Size(563, 165);
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
            imort_Image.Click += import_Image_Click;
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
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(0, 165);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(563, 287);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview.TabIndex = 2;
            pictureBoxPreview.TabStop = false;
            pictureBoxPreview.Click += pictureBoxPreview_Click;
            // 
            // save_patient_data
            // 
            save_patient_data.BackColor = Color.FromArgb(0, 64, 64);
            save_patient_data.ForeColor = Color.White;
            save_patient_data.Location = new Point(792, 474);
            save_patient_data.Name = "save_patient_data";
            save_patient_data.Size = new Size(75, 23);
            save_patient_data.TabIndex = 0;
            save_patient_data.Text = "SAVE";
            save_patient_data.UseVisualStyleBackColor = false;
            save_patient_data.Click += save_patient_data_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // addPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources.HD_wallpaper_dentist_neon_icon_blue_background_neon_symbols_dentist_neon_icons_dentist_sign_medical_signs_dentist_icon_medical_icons3;
            Controls.Add(save_patient_data);
            Controls.Add(delete_patient_data);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addPatient";
            Size = new Size(879, 500);
            Load += addPatient_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button delete_patient_data;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Button clear_fields_addP;
        private Button save_patient_data;
        private Button imort_Image;
        private Label name_addP;
        private TextBox field_name;
        private ComboBox field_gender;
        private Label gender_addP;
        private Label label3;
        private Label label2;
        private TextBox field_email;
        private TextBox field_surname;
        private Label label4;
        private TextBox field_phone;
        private Label label5;
        private Label label1;
        private TextBox treated_formula;
        private TextBox allergies_field;
        private Label label6;
        private ListView listView1;
        private ImageList imageList1;
        private OpenFileDialog openFileDialog1;
        private Button delete_image;
        private PictureBox pictureBoxPreview;
        private DateTimePicker DOB;
        private Label label8;
        private Label label7;
        private TextBox txtPatientId;
        private Button btnCancel;
        private Label lblStatus;
    }
}
