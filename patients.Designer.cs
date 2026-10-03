namespace DENTAL
{
    partial class patients
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
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            refresh_field = new Button();
            search_filter = new TextBox();
            pictureBox1 = new PictureBox();
            btnAdd = new Label();
            lblStatus = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(9, 81);
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
            dataGridView1.Size = new Size(869, 441);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Clipboard__1_;
            pictureBox2.Location = new Point(163, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // refresh_field
            // 
            refresh_field.BackColor = SystemColors.InactiveCaption;
            refresh_field.FlatAppearance.BorderSize = 0;
            refresh_field.ForeColor = Color.Transparent;
            refresh_field.Location = new Point(190, 54);
            refresh_field.Name = "refresh_field";
            refresh_field.Size = new Size(31, 23);
            refresh_field.TabIndex = 11;
            refresh_field.Text = "<>";
            refresh_field.UseVisualStyleBackColor = false;
            refresh_field.Click += refresh_field_Click;
            // 
            // search_filter
            // 
            search_filter.BackColor = Color.White;
            search_filter.Font = new Font("Segoe UI", 9F);
            search_filter.ForeColor = Color.Black;
            search_filter.Location = new Point(30, 54);
            search_filter.Margin = new Padding(3, 2, 3, 2);
            search_filter.Name = "search_filter";
            search_filter.Size = new Size(154, 23);
            search_filter.TabIndex = 10;
            search_filter.TextChanged += search_filter_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Image = Properties.Resources.icons8_patients_50__1_;
            pictureBox1.Location = new Point(900, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 25);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(0, 64, 64);
            btnAdd.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(782, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(54, 25);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "ADD";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(410, 11);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 64, 64);
            pictureBox3.Image = Properties.Resources.icons8_patients_50__1_;
            pictureBox3.Location = new Point(832, 11);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 25);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_wallpaper_dentist_neon_icon_blue_background_neon_symbols_dentist_neon_icons_dentist_sign_medical_signs_dentist_icon_medical_icons7;
            Controls.Add(pictureBox3);
            Controls.Add(lblStatus);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(refresh_field);
            Controls.Add(search_filter);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Name = "patients";
            Size = new Size(886, 518);
            Load += patients_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Button refresh_field;
        private TextBox search_filter;
        private PictureBox pictureBox1;
        private Label btnAdd;
        private Label lblStatus;
        private PictureBox pictureBox3;
    }
}
