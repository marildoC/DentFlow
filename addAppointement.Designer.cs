
namespace DENTAL
{
    partial class addAppointement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAppointement));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpApptDate = new DateTimePicker();
            maskTime = new MaskedTextBox();
            cmbDentist = new ComboBox();
            txtNotes = new TextBox();
            txtPatient = new TextBox();
            listBox_patient = new ListBox();
            cancel_bttn = new CheckBox();
            save_appointement_bttn = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 6);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 0;
            label1.Text = "Appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Dentist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 64, 64);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Patient";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 64, 64);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 171);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 64, 64);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 215);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 0;
            label5.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 64, 64);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 259);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "Notes";
            // 
            // dtpApptDate
            // 
            dtpApptDate.Location = new Point(72, 165);
            dtpApptDate.Name = "dtpApptDate";
            dtpApptDate.Size = new Size(200, 23);
            dtpApptDate.TabIndex = 1;
            dtpApptDate.ValueChanged += dtpApptDate_ValueChanged;
            // 
            // maskTime
            // 
            maskTime.Culture = new System.Globalization.CultureInfo("es-US");
            maskTime.Location = new Point(72, 212);
            maskTime.Mask = "00:00";
            maskTime.Name = "maskTime";
            maskTime.ShortcutsEnabled = false;
            maskTime.Size = new Size(57, 23);
            maskTime.TabIndex = 2;
            maskTime.MaskInputRejected += maskTime_MaskInputRejected;
            // 
            // cmbDentist
            // 
            cmbDentist.FormattingEnabled = true;
            cmbDentist.Location = new Point(73, 56);
            cmbDentist.Name = "cmbDentist";
            cmbDentist.Size = new Size(121, 23);
            cmbDentist.TabIndex = 3;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(66, 256);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(225, 105);
            txtNotes.TabIndex = 4;
            txtNotes.TextChanged += txtNotes_TextChanged;
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(74, 104);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(120, 23);
            txtPatient.TabIndex = 5;
            txtPatient.TextChanged += txtPatient_TextChanged;
            // 
            // listBox_patient
            // 
            listBox_patient.FormattingEnabled = true;
            listBox_patient.ItemHeight = 15;
            listBox_patient.Location = new Point(72, 35);
            listBox_patient.Name = "listBox_patient";
            listBox_patient.Size = new Size(217, 124);
            listBox_patient.TabIndex = 6;
            listBox_patient.Visible = false;
            listBox_patient.SelectedIndexChanged += listBox_patient_SelectedIndexChanged;
            // 
            // cancel_bttn
            // 
            cancel_bttn.AutoSize = true;
            cancel_bttn.BackColor = Color.Teal;
            cancel_bttn.Location = new Point(28, 367);
            cancel_bttn.Name = "cancel_bttn";
            cancel_bttn.Size = new Size(62, 19);
            cancel_bttn.TabIndex = 11;
            cancel_bttn.Text = "Cancel";
            cancel_bttn.UseVisualStyleBackColor = false;
            cancel_bttn.CheckedChanged += cancel_bttn_CheckedChanged;
            // 
            // save_appointement_bttn
            // 
            save_appointement_bttn.BackColor = Color.FromArgb(64, 0, 0);
            save_appointement_bttn.ForeColor = Color.FromArgb(0, 192, 192);
            save_appointement_bttn.Location = new Point(197, 387);
            save_appointement_bttn.Name = "save_appointement_bttn";
            save_appointement_bttn.Size = new Size(75, 23);
            save_appointement_bttn.TabIndex = 12;
            save_appointement_bttn.Text = "Save";
            save_appointement_bttn.UseVisualStyleBackColor = false;
            save_appointement_bttn.Click += save_appointement_bttn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(276, 4);
            label7.Name = "label7";
            label7.Size = new Size(17, 17);
            label7.TabIndex = 0;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // addAppointement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(listBox_patient);
            Controls.Add(save_appointement_bttn);
            Controls.Add(cancel_bttn);
            Controls.Add(txtPatient);
            Controls.Add(txtNotes);
            Controls.Add(cmbDentist);
            Controls.Add(maskTime);
            Controls.Add(dtpApptDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "addAppointement";
            Size = new Size(302, 434);
            Load += addAppointement_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpApptDate;
        private MaskedTextBox maskTime;
        private ComboBox cmbDentist;
        private TextBox txtNotes;
        private TextBox txtPatient;
        private ListBox listBox_patient;
        private CheckBox cancel_bttn;
        private Button save_appointement_bttn;
        private Label label7;
    }
}
