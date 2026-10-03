namespace DENTAL
{
    partial class Appointments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblStatus = new Label();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            refresh_field = new Button();
            search_filter = new TextBox();
            add_appointment = new Label();
            pick_day_appointment = new DateTimePicker();
            active_bttn = new Button();
            cancelled_bttn = new Button();
            create_treatment_session = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(411, 3);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 77, 83);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(867, 411);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Clipboard__1_;
            pictureBox2.Location = new Point(164, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // refresh_field
            // 
            refresh_field.BackColor = SystemColors.InactiveCaption;
            refresh_field.FlatAppearance.BorderSize = 0;
            refresh_field.ForeColor = Color.Transparent;
            refresh_field.Location = new Point(191, 46);
            refresh_field.Name = "refresh_field";
            refresh_field.Size = new Size(31, 23);
            refresh_field.TabIndex = 25;
            refresh_field.Text = "<>";
            refresh_field.UseVisualStyleBackColor = false;
            refresh_field.Click += refresh_field_Click_1;
            // 
            // search_filter
            // 
            search_filter.BackColor = Color.White;
            search_filter.Font = new Font("Segoe UI", 9F);
            search_filter.ForeColor = Color.Black;
            search_filter.Location = new Point(31, 46);
            search_filter.Margin = new Padding(3, 2, 3, 2);
            search_filter.Name = "search_filter";
            search_filter.Size = new Size(154, 23);
            search_filter.TabIndex = 24;
            search_filter.TextChanged += search_filter_TextChanged;
            // 
            // add_appointment
            // 
            add_appointment.AutoSize = true;
            add_appointment.BackColor = Color.FromArgb(0, 64, 64);
            add_appointment.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_appointment.ForeColor = Color.White;
            add_appointment.Location = new Point(801, 19);
            add_appointment.Name = "add_appointment";
            add_appointment.Size = new Size(54, 25);
            add_appointment.TabIndex = 23;
            add_appointment.Text = "ADD";
            add_appointment.Click += add_appointment_Click;
            // 
            // pick_day_appointment
            // 
            pick_day_appointment.Location = new Point(15, 75);
            pick_day_appointment.Name = "pick_day_appointment";
            pick_day_appointment.Size = new Size(207, 23);
            pick_day_appointment.TabIndex = 30;
            pick_day_appointment.ValueChanged += pick_day_appointment_ValueChanged;
            // 
            // active_bttn
            // 
            active_bttn.ForeColor = Color.Gold;
            active_bttn.Location = new Point(228, 75);
            active_bttn.Name = "active_bttn";
            active_bttn.Size = new Size(75, 23);
            active_bttn.TabIndex = 31;
            active_bttn.Text = "Active";
            active_bttn.UseVisualStyleBackColor = true;
            active_bttn.Click += active_bttn_Click;
            // 
            // cancelled_bttn
            // 
            cancelled_bttn.BackColor = Color.White;
            cancelled_bttn.BackgroundImageLayout = ImageLayout.Center;
            cancelled_bttn.ForeColor = Color.Gold;
            cancelled_bttn.Location = new Point(309, 77);
            cancelled_bttn.Name = "cancelled_bttn";
            cancelled_bttn.Size = new Size(69, 23);
            cancelled_bttn.TabIndex = 31;
            cancelled_bttn.Text = "Cancelled";
            cancelled_bttn.UseVisualStyleBackColor = false;
            cancelled_bttn.Click += cancelled_bttn_Click;
            // 
            // create_treatment_session
            // 
            create_treatment_session.Location = new Point(598, 75);
            create_treatment_session.Name = "create_treatment_session";
            create_treatment_session.Size = new Size(158, 23);
            create_treatment_session.TabIndex = 32;
            create_treatment_session.Text = "Create Treatment Session";
            create_treatment_session.UseVisualStyleBackColor = true;
            create_treatment_session.Visible = false;
            create_treatment_session.Click += create_treatment_session_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(34, 77, 83);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(10, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(867, 411);
            dataGridView2.TabIndex = 27;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_wallpaper_dentist_neon_icon_blue_background_neon_symbols_dentist_neon_icons_dentist_sign_medical_signs_dentist_icon_medical_icons5;
            Controls.Add(create_treatment_session);
            Controls.Add(cancelled_bttn);
            Controls.Add(active_bttn);
            Controls.Add(pick_day_appointment);
            Controls.Add(lblStatus);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(refresh_field);
            Controls.Add(search_filter);
            Controls.Add(add_appointment);
            Name = "Appointments";
            Size = new Size(886, 518);
            Load += Appointments_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStatus;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Button refresh_field;
        private TextBox search_filter;
        private Label add_appointment;
        private DateTimePicker pick_day_appointment;
        private Button active_bttn;
        private Button cancelled_bttn;
        private Button create_treatment_session;
        private DataGridView dataGridView2;
    }
}
