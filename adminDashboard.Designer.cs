namespace DENTAL
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            label6 = new Label();
            active_appointment = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            canceled_appointment = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            label2 = new Label();
            today_appointment = new Label();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            label10 = new Label();
            new_patients = new Label();
            pictureBox2 = new PictureBox();
            dataGridViewToday = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToday).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Location = new Point(19, 27);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(843, 141);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(active_appointment);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(251, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 86);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 61);
            label6.Name = "label6";
            label6.Size = new Size(132, 14);
            label6.TabIndex = 1;
            label6.Text = " Active Appointments";
            // 
            // active_appointment
            // 
            active_appointment.AutoSize = true;
            active_appointment.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            active_appointment.ForeColor = Color.White;
            active_appointment.Location = new Point(113, 10);
            active_appointment.Name = "active_appointment";
            active_appointment.Size = new Size(25, 30);
            active_appointment.TabIndex = 1;
            active_appointment.Text = "0";
            active_appointment.Click += active_appointment_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.active;
            pictureBox3.Location = new Point(13, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 38);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(canceled_appointment);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(471, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 86);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 61);
            label4.Name = "label4";
            label4.Size = new Size(147, 14);
            label4.TabIndex = 1;
            label4.Text = "Canceled Appointments";
            // 
            // canceled_appointment
            // 
            canceled_appointment.AutoSize = true;
            canceled_appointment.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            canceled_appointment.ForeColor = Color.White;
            canceled_appointment.Location = new Point(116, 10);
            canceled_appointment.Name = "canceled_appointment";
            canceled_appointment.Size = new Size(25, 30);
            canceled_appointment.TabIndex = 1;
            canceled_appointment.Text = "0";
            canceled_appointment.Click += canceled_appointment_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Canceled;
            pictureBox4.Location = new Point(7, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 38);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(today_appointment);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(47, 57);
            panel6.Name = "panel6";
            panel6.Size = new Size(154, 86);
            panel6.TabIndex = 0;
            panel6.Paint += panel4_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(140, 14);
            label2.TabIndex = 1;
            label2.Text = "Today’s Appointments";
            // 
            // today_appointment
            // 
            today_appointment.AutoSize = true;
            today_appointment.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            today_appointment.ForeColor = Color.White;
            today_appointment.Location = new Point(116, 10);
            today_appointment.Name = "today_appointment";
            today_appointment.Size = new Size(25, 30);
            today_appointment.TabIndex = 1;
            today_appointment.Text = "0";
            today_appointment.Click += today_appointment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(new_patients);
            panel7.Controls.Add(pictureBox2);
            panel7.Location = new Point(684, 57);
            panel7.Name = "panel7";
            panel7.Size = new Size(154, 86);
            panel7.TabIndex = 0;
            panel7.Paint += panel2_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(33, 57);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 1;
            label10.Text = "New Patients";
            // 
            // new_patients
            // 
            new_patients.AutoSize = true;
            new_patients.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_patients.ForeColor = Color.White;
            new_patients.Location = new Point(116, 10);
            new_patients.Name = "new_patients";
            new_patients.Size = new Size(25, 30);
            new_patients.TabIndex = 1;
            new_patients.Text = "0";
            new_patients.Click += new_patients_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Clipboard;
            pictureBox2.Location = new Point(12, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dataGridViewToday
            // 
            dataGridViewToday.AllowUserToAddRows = false;
            dataGridViewToday.AllowUserToDeleteRows = false;
            dataGridViewToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewToday.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 77, 83);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewToday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewToday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewToday.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewToday.EnableHeadersVisualStyles = false;
            dataGridViewToday.Location = new Point(19, 178);
            dataGridViewToday.Name = "dataGridViewToday";
            dataGridViewToday.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewToday.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewToday.RowHeadersVisible = false;
            dataGridViewToday.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewToday.Size = new Size(843, 314);
            dataGridViewToday.TabIndex = 14;
            dataGridViewToday.CellContentClick += dataGridViewToday_CellContentClick;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_wallpaper_dentist_neon_icon_blue_background_neon_symbols_dentist_neon_icons_dentist_sign_medical_signs_dentist_icon_medical_icons9;
            Controls.Add(dataGridViewToday);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel2);
            Name = "adminDashboard";
            Size = new Size(879, 500);
            Load += adminDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToday).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox1;
        private Label label2;
        private Label today_appointment;
        private Label label6;
        private Label active_appointment;
        private Label canceled_appointment;
        private Label label10;
        private Label new_patients;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DataGridView dataGridViewToday;
    }
}
