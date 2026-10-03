namespace DENTAL
{
    partial class patientForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtSearch = new TextBox();
            refresh_field = new Button();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            sqlDataRecordBindingSource = new BindingSource(components);
            patientFormBindingSource = new BindingSource(components);
            sqlConnectionBindingSource = new BindingSource(components);
            registerFormBindingSource = new BindingSource(components);
            patientsBindingSource = new BindingSource(components);
            addPatientBindingSource = new BindingSource(components);
            sqlConnectionBindingSource1 = new BindingSource(components);
            sqlConnectionBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registerFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addPatientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(785, 28);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "ADD     ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Image = Properties.Resources.icons8_patients_50__1_;
            pictureBox1.Location = new Point(840, 28);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 25);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Patients";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ButtonFace;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(49, 51);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(154, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // refresh_field
            // 
            refresh_field.BackColor = SystemColors.InactiveCaption;
            refresh_field.FlatAppearance.BorderSize = 0;
            refresh_field.ForeColor = Color.Transparent;
            refresh_field.Location = new Point(209, 51);
            refresh_field.Name = "refresh_field";
            refresh_field.Size = new Size(31, 23);
            refresh_field.TabIndex = 4;
            refresh_field.Text = "<>";
            refresh_field.UseVisualStyleBackColor = false;
           // refresh_field.Click += refresh_field_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Clipboard__1_;
            pictureBox2.Location = new Point(182, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(87, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(571, 184);
            dataGridView1.TabIndex = 6;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // sqlDataRecordBindingSource
            // 
            sqlDataRecordBindingSource.DataSource = typeof(Microsoft.Data.SqlClient.Server.SqlDataRecord);
            // 
            // patientFormBindingSource
            // 
            patientFormBindingSource.DataSource = typeof(patientForm);
            // 
            // sqlConnectionBindingSource
            // 
            sqlConnectionBindingSource.DataSource = typeof(Microsoft.Data.SqlClient.SqlConnection);
            // 
            // registerFormBindingSource
            // 
            registerFormBindingSource.DataSource = typeof(registerForm);
            // 
            // patientsBindingSource
            // 
            patientsBindingSource.DataSource = typeof(patients);
            // 
            // addPatientBindingSource
            // 
            addPatientBindingSource.DataSource = typeof(addPatient);
            // 
            // sqlConnectionBindingSource1
            // 
            sqlConnectionBindingSource1.DataSource = typeof(Microsoft.Data.SqlClient.SqlConnection);
            // 
            // sqlConnectionBindingSource2
            // 
            sqlConnectionBindingSource2.DataSource = typeof(Microsoft.Data.SqlClient.SqlConnection);
            // 
            // patientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(refresh_field);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "patientForm";
            Size = new Size(879, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)registerFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)addPatientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtSearch;
        private Button refresh_field;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private BindingSource patientFormBindingSource;
        private BindingSource sqlConnectionBindingSource;
        private BindingSource sqlConnectionBindingSource1;
        private BindingSource registerFormBindingSource;
        private BindingSource patientsBindingSource;
        private BindingSource addPatientBindingSource;
        private BindingSource sqlDataRecordBindingSource;
        private BindingSource sqlConnectionBindingSource2;
    }
}
