namespace DENTAL 
{
    partial class Treatment 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Treatment));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ConsultationNote = new TextBox();
            Prescriptions = new TextBox();
            label6 = new Label();
            AppIDLabel = new Label();
            DentistNameLabel = new Label();
            PatientNameLabel = new Label();
            ViewReceiptButton = new Button();
            TotalLabel = new Label();
            DoneButton = new Button();
            BillingTable = new TableLayoutPanel();
            AmountBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            ExitButton = new Button();
            AddRowButton = new Button();
            ClearButton = new Button();
            label13 = new Label();
            BillingTable.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "App.ID ";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 51);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Patient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 292);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Total: $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 64, 64);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 130);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 0;
            label4.Text = "Consulation Note";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 64, 64);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 216);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 0;
            label5.Text = "Prescriptions";
            // 
            // ConsultationNote
            // 
            ConsultationNote.Location = new Point(27, 148);
            ConsultationNote.Multiline = true;
            ConsultationNote.Name = "ConsultationNote";
            ConsultationNote.Size = new Size(268, 66);
            ConsultationNote.TabIndex = 5;
            // 
            // Prescriptions
            // 
            Prescriptions.Location = new Point(27, 234);
            Prescriptions.Multiline = true;
            Prescriptions.Name = "Prescriptions";
            Prescriptions.Size = new Size(268, 73);
            Prescriptions.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(351, 17);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 0;
            label6.Text = "Billing";
            // 
            // AppIDLabel
            // 
            AppIDLabel.AutoSize = true;
            AppIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            AppIDLabel.ForeColor = Color.FromArgb(0, 192, 192);
            AppIDLabel.Location = new Point(112, 24);
            AppIDLabel.Name = "AppIDLabel";
            AppIDLabel.Size = new Size(18, 15);
            AppIDLabel.TabIndex = 6;
            AppIDLabel.Text = "ID";
            AppIDLabel.Visible = false;
            // 
            // DentistNameLabel
            // 
            DentistNameLabel.AutoSize = true;
            DentistNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DentistNameLabel.ForeColor = Color.FromArgb(0, 192, 192);
            DentistNameLabel.Location = new Point(109, 86);
            DentistNameLabel.Name = "DentistNameLabel";
            DentistNameLabel.Size = new Size(78, 15);
            DentistNameLabel.TabIndex = 6;
            DentistNameLabel.Text = "dentist_name";
            // 
            // PatientNameLabel
            // 
            PatientNameLabel.AutoSize = true;
            PatientNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientNameLabel.ForeColor = Color.FromArgb(0, 192, 192);
            PatientNameLabel.Location = new Point(109, 52);
            PatientNameLabel.Name = "PatientNameLabel";
            PatientNameLabel.Size = new Size(79, 15);
            PatientNameLabel.TabIndex = 6;
            PatientNameLabel.Text = "patient_name";
            // 
            // ViewReceiptButton
            // 
            ViewReceiptButton.BackColor = Color.FromArgb(64, 0, 0);
            ViewReceiptButton.ForeColor = Color.White;
            ViewReceiptButton.Location = new Point(448, 288);
            ViewReceiptButton.Name = "ViewReceiptButton";
            ViewReceiptButton.Size = new Size(89, 23);
            ViewReceiptButton.TabIndex = 7;
            ViewReceiptButton.Text = "View Receipt";
            ViewReceiptButton.UseVisualStyleBackColor = false;
            ViewReceiptButton.Click += ViewReceiptButton_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.ForeColor = Color.FromArgb(0, 192, 192);
            TotalLabel.Location = new Point(377, 292);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(22, 15);
            TotalLabel.TabIndex = 0;
            TotalLabel.Text = "0.0";
            // 
            // DoneButton
            // 
            DoneButton.BackColor = Color.FromArgb(64, 0, 0);
            DoneButton.ForeColor = Color.White;
            DoneButton.Location = new Point(543, 288);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(66, 23);
            DoneButton.TabIndex = 7;
            DoneButton.Text = "DONE";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += DoneButton_Click;
            // 
            // BillingTable
            // 
            BillingTable.ColumnCount = 2;
            BillingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.15356F));
            BillingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8464413F));
            BillingTable.Controls.Add(AmountBox, 1, 0);
            BillingTable.Controls.Add(textBox1, 0, 1);
            BillingTable.Controls.Add(textBox2, 0, 0);
            BillingTable.Controls.Add(textBox4, 0, 2);
            BillingTable.Controls.Add(textBox3, 1, 1);
            BillingTable.Controls.Add(textBox5, 1, 2);
            BillingTable.Controls.Add(textBox6, 1, 3);
            BillingTable.Controls.Add(textBox7, 1, 4);
            BillingTable.Controls.Add(textBox8, 1, 5);
            BillingTable.Controls.Add(textBox9, 1, 6);
            BillingTable.Controls.Add(textBox10, 0, 3);
            BillingTable.Controls.Add(textBox11, 0, 4);
            BillingTable.Controls.Add(textBox12, 0, 5);
            BillingTable.Controls.Add(textBox13, 0, 6);
            BillingTable.Location = new Point(351, 68);
            BillingTable.Name = "BillingTable";
            BillingTable.RowCount = 7;
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            BillingTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BillingTable.Size = new Size(267, 197);
            BillingTable.TabIndex = 8;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(209, 3);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(55, 23);
            AmountBox.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 61);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 61);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(55, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(209, 91);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(55, 23);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(209, 120);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(55, 23);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(209, 148);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(55, 23);
            textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(209, 176);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(55, 23);
            textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(3, 91);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(200, 23);
            textBox10.TabIndex = 27;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(3, 120);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(200, 23);
            textBox11.TabIndex = 27;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(3, 148);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(200, 23);
            textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(3, 176);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(200, 23);
            textBox13.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 64, 64);
            label11.ForeColor = Color.White;
            label11.Location = new Point(29, 86);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 0;
            label11.Text = "Dentist";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Teal;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(351, 45);
            label12.Name = "label12";
            label12.Size = new Size(197, 20);
            label12.TabIndex = 0;
            label12.Text = "                 Description          ";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(586, 17);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(32, 24);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // AddRowButton
            // 
            AddRowButton.BackColor = Color.Green;
            AddRowButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddRowButton.ForeColor = Color.White;
            AddRowButton.Location = new Point(554, 16);
            AddRowButton.Name = "AddRowButton";
            AddRowButton.Size = new Size(32, 25);
            AddRowButton.TabIndex = 9;
            AddRowButton.Text = "+";
            AddRowButton.UseVisualStyleBackColor = false;
            AddRowButton.Click += AddRowButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.InactiveCaption;
            ClearButton.FlatAppearance.BorderSize = 0;
            ClearButton.ForeColor = Color.Transparent;
            ClearButton.Location = new Point(517, 18);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(31, 23);
            ClearButton.TabIndex = 26;
            ClearButton.Text = "<>";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Teal;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(527, 45);
            label13.Name = "label13";
            label13.Size = new Size(91, 20);
            label13.TabIndex = 0;
            label13.Text = "      Amount";
            // 
            // Treatment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(ClearButton);
            Controls.Add(AddRowButton);
            Controls.Add(ExitButton);
            Controls.Add(BillingTable);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(DoneButton);
            Controls.Add(ViewReceiptButton);
            Controls.Add(PatientNameLabel);
            Controls.Add(DentistNameLabel);
            Controls.Add(AppIDLabel);
            Controls.Add(Prescriptions);
            Controls.Add(ConsultationNote);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TotalLabel);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "Treatment";
            Size = new Size(633, 323);
            Load += Treatment_Load;
            BillingTable.ResumeLayout(false);
            BillingTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ConsultationNote;
        private TextBox Prescriptions;
        private Label label6;
        private Label AppIDLabel;
        private Label DentistNameLabel;
        private Label PatientNameLabel;
        private Button ViewReceiptButton;
        private Label TotalLabel;
        private Button DoneButton;
        private TableLayoutPanel BillingTable;
        private Label label11;
        private Label label12;
        private TextBox AmountBox;
        private TextBox textBox3;
        private Button ExitButton;
        private Button AddRowButton;
        private Button ClearButton;
        private Label label13;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
    }
}
