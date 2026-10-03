namespace DENTAL
{
    partial class setting
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            refresh_fields = new Button();
            tableLayoutPanel_Sunday = new TableLayoutPanel();
            mtbSunOpen1 = new MaskedTextBox();
            mtbSunClose1 = new MaskedTextBox();
            mtbSunOpen2 = new MaskedTextBox();
            mtbSunClose2 = new MaskedTextBox();
            tableLayoutPanel_Saturday = new TableLayoutPanel();
            mtbSatOpen1 = new MaskedTextBox();
            mtbSatClose1 = new MaskedTextBox();
            mtbSatOpen2 = new MaskedTextBox();
            mtbSatClose2 = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label15 = new Label();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            tableLayoutPanel_Friday = new TableLayoutPanel();
            mtbFriOpen1 = new MaskedTextBox();
            mtbFriClose1 = new MaskedTextBox();
            mtbFriOpen2 = new MaskedTextBox();
            mtbFriClose2 = new MaskedTextBox();
            tableLayoutPanel_Thursday = new TableLayoutPanel();
            mtbThurOpen1 = new MaskedTextBox();
            mtbThurClose1 = new MaskedTextBox();
            mtbThurOpen2 = new MaskedTextBox();
            mtbThurClose2 = new MaskedTextBox();
            tableLayoutPanel_Wednesday = new TableLayoutPanel();
            mtbWedOpen1 = new MaskedTextBox();
            mtbWedClose1 = new MaskedTextBox();
            mtbWedOpen2 = new MaskedTextBox();
            mtbWedClose2 = new MaskedTextBox();
            tableLayoutPanel_Monday = new TableLayoutPanel();
            mtbMonOpen1 = new MaskedTextBox();
            mtbMonClose1 = new MaskedTextBox();
            mtbMonOpen2 = new MaskedTextBox();
            mtbMonClose2 = new MaskedTextBox();
            tableLayoutPanel_Tuesday = new TableLayoutPanel();
            mtbTueOpen1 = new MaskedTextBox();
            mtbTueClose1 = new MaskedTextBox();
            mtbTueOpen2 = new MaskedTextBox();
            mtbTueClose2 = new MaskedTextBox();
            label13 = new Label();
            label14 = new Label();
            txtClinicName = new TextBox();
            Save_setting = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel_Sunday.SuspendLayout();
            tableLayoutPanel_Saturday.SuspendLayout();
            tableLayoutPanel_Friday.SuspendLayout();
            tableLayoutPanel_Thursday.SuspendLayout();
            tableLayoutPanel_Wednesday.SuspendLayout();
            tableLayoutPanel_Monday.SuspendLayout();
            tableLayoutPanel_Tuesday.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 82);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Dental Name";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 64, 64);
            groupBox1.Controls.Add(refresh_fields);
            groupBox1.Controls.Add(tableLayoutPanel_Sunday);
            groupBox1.Controls.Add(tableLayoutPanel_Saturday);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tableLayoutPanel_Friday);
            groupBox1.Controls.Add(tableLayoutPanel_Thursday);
            groupBox1.Controls.Add(tableLayoutPanel_Wednesday);
            groupBox1.Controls.Add(tableLayoutPanel_Monday);
            groupBox1.Controls.Add(tableLayoutPanel_Tuesday);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(240, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 336);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Working Hours";
            // 
            // refresh_fields
            // 
            refresh_fields.BackColor = SystemColors.InactiveCaption;
            refresh_fields.FlatAppearance.BorderSize = 0;
            refresh_fields.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refresh_fields.ForeColor = Color.Transparent;
            refresh_fields.Location = new Point(385, 303);
            refresh_fields.Name = "refresh_fields";
            refresh_fields.Size = new Size(61, 24);
            refresh_fields.TabIndex = 19;
            refresh_fields.Text = "Clear All";
            refresh_fields.UseVisualStyleBackColor = false;
            refresh_fields.Click += refresh_fields_Click;
            // 
            // tableLayoutPanel_Sunday
            // 
            tableLayoutPanel_Sunday.BackColor = Color.White;
            tableLayoutPanel_Sunday.ColumnCount = 4;
            tableLayoutPanel_Sunday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Sunday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Sunday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Sunday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Sunday.Controls.Add(mtbSunOpen1, 0, 0);
            tableLayoutPanel_Sunday.Controls.Add(mtbSunClose1, 1, 0);
            tableLayoutPanel_Sunday.Controls.Add(mtbSunOpen2, 2, 0);
            tableLayoutPanel_Sunday.Controls.Add(mtbSunClose2, 3, 0);
            tableLayoutPanel_Sunday.Location = new Point(124, 269);
            tableLayoutPanel_Sunday.Name = "tableLayoutPanel_Sunday";
            tableLayoutPanel_Sunday.RowCount = 1;
            tableLayoutPanel_Sunday.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Sunday.Size = new Size(257, 28);
            tableLayoutPanel_Sunday.TabIndex = 3;
            tableLayoutPanel_Sunday.Paint += tableLayoutPanel_Sunday_Paint;
            // 
            // mtbSunOpen1
            // 
            mtbSunOpen1.Location = new Point(3, 3);
            mtbSunOpen1.Mask = "00:00";
            mtbSunOpen1.Name = "mtbSunOpen1";
            mtbSunOpen1.ShortcutsEnabled = false;
            mtbSunOpen1.Size = new Size(46, 29);
            mtbSunOpen1.TabIndex = 5;
            mtbSunOpen1.Tag = "      ";
            mtbSunOpen1.MaskInputRejected += mtbSunOpen1_MaskInputRejected;
            // 
            // mtbSunClose1
            // 
            mtbSunClose1.Location = new Point(67, 3);
            mtbSunClose1.Mask = "00:00";
            mtbSunClose1.Name = "mtbSunClose1";
            mtbSunClose1.ShortcutsEnabled = false;
            mtbSunClose1.Size = new Size(46, 29);
            mtbSunClose1.TabIndex = 5;
            mtbSunClose1.Tag = "      ";
            mtbSunClose1.MaskInputRejected += mtbSunClose1_MaskInputRejected;
            // 
            // mtbSunOpen2
            // 
            mtbSunOpen2.Location = new Point(131, 3);
            mtbSunOpen2.Mask = "00:00";
            mtbSunOpen2.Name = "mtbSunOpen2";
            mtbSunOpen2.ShortcutsEnabled = false;
            mtbSunOpen2.Size = new Size(46, 29);
            mtbSunOpen2.TabIndex = 5;
            mtbSunOpen2.Tag = "      ";
            mtbSunOpen2.MaskInputRejected += mtbSunOpen2_MaskInputRejected;
            // 
            // mtbSunClose2
            // 
            mtbSunClose2.Location = new Point(195, 3);
            mtbSunClose2.Mask = "00:00";
            mtbSunClose2.Name = "mtbSunClose2";
            mtbSunClose2.ShortcutsEnabled = false;
            mtbSunClose2.Size = new Size(46, 29);
            mtbSunClose2.TabIndex = 5;
            mtbSunClose2.Tag = "      ";
            mtbSunClose2.MaskInputRejected += mtbSunClose2_MaskInputRejected;
            // 
            // tableLayoutPanel_Saturday
            // 
            tableLayoutPanel_Saturday.BackColor = Color.White;
            tableLayoutPanel_Saturday.ColumnCount = 4;
            tableLayoutPanel_Saturday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Saturday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Saturday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Saturday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Saturday.Controls.Add(mtbSatOpen1, 0, 0);
            tableLayoutPanel_Saturday.Controls.Add(mtbSatClose1, 1, 0);
            tableLayoutPanel_Saturday.Controls.Add(mtbSatOpen2, 2, 0);
            tableLayoutPanel_Saturday.Controls.Add(mtbSatClose2, 3, 0);
            tableLayoutPanel_Saturday.Location = new Point(124, 235);
            tableLayoutPanel_Saturday.Name = "tableLayoutPanel_Saturday";
            tableLayoutPanel_Saturday.RowCount = 1;
            tableLayoutPanel_Saturday.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Saturday.Size = new Size(257, 28);
            tableLayoutPanel_Saturday.TabIndex = 3;
            tableLayoutPanel_Saturday.Paint += tableLayoutPanel_Saturday_Paint;
            // 
            // mtbSatOpen1
            // 
            mtbSatOpen1.Location = new Point(3, 3);
            mtbSatOpen1.Mask = "00:00";
            mtbSatOpen1.Name = "mtbSatOpen1";
            mtbSatOpen1.ShortcutsEnabled = false;
            mtbSatOpen1.Size = new Size(46, 29);
            mtbSatOpen1.TabIndex = 5;
            mtbSatOpen1.Tag = "      ";
            mtbSatOpen1.MaskInputRejected += mtbSatOpen1_MaskInputRejected;
            // 
            // mtbSatClose1
            // 
            mtbSatClose1.Location = new Point(67, 3);
            mtbSatClose1.Mask = "00:00";
            mtbSatClose1.Name = "mtbSatClose1";
            mtbSatClose1.ShortcutsEnabled = false;
            mtbSatClose1.Size = new Size(46, 29);
            mtbSatClose1.TabIndex = 5;
            mtbSatClose1.Tag = "      ";
            mtbSatClose1.MaskInputRejected += mtbSatClose1_MaskInputRejected;
            // 
            // mtbSatOpen2
            // 
            mtbSatOpen2.Location = new Point(131, 3);
            mtbSatOpen2.Mask = "00:00";
            mtbSatOpen2.Name = "mtbSatOpen2";
            mtbSatOpen2.ShortcutsEnabled = false;
            mtbSatOpen2.Size = new Size(46, 29);
            mtbSatOpen2.TabIndex = 5;
            mtbSatOpen2.Tag = "      ";
            mtbSatOpen2.MaskInputRejected += mtbSatOpen2_MaskInputRejected;
            // 
            // mtbSatClose2
            // 
            mtbSatClose2.Location = new Point(195, 3);
            mtbSatClose2.Mask = "00:00";
            mtbSatClose2.Name = "mtbSatClose2";
            mtbSatClose2.ShortcutsEnabled = false;
            mtbSatClose2.Size = new Size(46, 29);
            mtbSatClose2.TabIndex = 5;
            mtbSatClose2.Tag = "      ";
            mtbSatClose2.MaskInputRejected += mtbSatClose2_MaskInputRejected;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 267);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 0;
            label8.Text = "Sunday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 236);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 0;
            label7.Text = "Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 201);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 0;
            label6.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 167);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 0;
            label5.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 133);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 0;
            label4.Text = "Wednesday";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 72);
            label15.Name = "label15";
            label15.Size = new Size(73, 21);
            label15.TabIndex = 0;
            label15.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 99);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 0;
            label3.Text = "Tuesday";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(326, 39);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 0;
            label11.Text = "Close";
            label11.Click += label2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(246, 38);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 0;
            label12.Text = "Open Miday";
            label12.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(175, 38);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 0;
            label10.Text = "Close Miday";
            label10.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(131, 38);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 0;
            label9.Text = "Open";
            label9.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(141, 38);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Open";
            label2.Click += label2_Click;
            // 
            // tableLayoutPanel_Friday
            // 
            tableLayoutPanel_Friday.BackColor = Color.White;
            tableLayoutPanel_Friday.ColumnCount = 4;
            tableLayoutPanel_Friday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Friday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Friday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Friday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Friday.Controls.Add(mtbFriOpen1, 0, 0);
            tableLayoutPanel_Friday.Controls.Add(mtbFriClose1, 1, 0);
            tableLayoutPanel_Friday.Controls.Add(mtbFriOpen2, 2, 0);
            tableLayoutPanel_Friday.Controls.Add(mtbFriClose2, 3, 0);
            tableLayoutPanel_Friday.Location = new Point(124, 201);
            tableLayoutPanel_Friday.Name = "tableLayoutPanel_Friday";
            tableLayoutPanel_Friday.RowCount = 1;
            tableLayoutPanel_Friday.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Friday.Size = new Size(257, 28);
            tableLayoutPanel_Friday.TabIndex = 3;
            tableLayoutPanel_Friday.Paint += tableLayoutPanel_Friday_Paint;
            // 
            // mtbFriOpen1
            // 
            mtbFriOpen1.Location = new Point(3, 3);
            mtbFriOpen1.Mask = "00:00";
            mtbFriOpen1.Name = "mtbFriOpen1";
            mtbFriOpen1.ShortcutsEnabled = false;
            mtbFriOpen1.Size = new Size(46, 29);
            mtbFriOpen1.TabIndex = 5;
            mtbFriOpen1.Tag = "      ";
            mtbFriOpen1.MaskInputRejected += mtbFriOpen1_MaskInputRejected;
            // 
            // mtbFriClose1
            // 
            mtbFriClose1.Location = new Point(67, 3);
            mtbFriClose1.Mask = "00:00";
            mtbFriClose1.Name = "mtbFriClose1";
            mtbFriClose1.ShortcutsEnabled = false;
            mtbFriClose1.Size = new Size(46, 29);
            mtbFriClose1.TabIndex = 5;
            mtbFriClose1.Tag = "      ";
            mtbFriClose1.MaskInputRejected += mtbFriClose1_MaskInputRejected;
            // 
            // mtbFriOpen2
            // 
            mtbFriOpen2.Location = new Point(131, 3);
            mtbFriOpen2.Mask = "00:00";
            mtbFriOpen2.Name = "mtbFriOpen2";
            mtbFriOpen2.ShortcutsEnabled = false;
            mtbFriOpen2.Size = new Size(46, 29);
            mtbFriOpen2.TabIndex = 5;
            mtbFriOpen2.Tag = "      ";
            mtbFriOpen2.MaskInputRejected += mtbFriOpen2_MaskInputRejected;
            // 
            // mtbFriClose2
            // 
            mtbFriClose2.Location = new Point(195, 3);
            mtbFriClose2.Mask = "00:00";
            mtbFriClose2.Name = "mtbFriClose2";
            mtbFriClose2.ShortcutsEnabled = false;
            mtbFriClose2.Size = new Size(46, 29);
            mtbFriClose2.TabIndex = 5;
            mtbFriClose2.Tag = "      ";
            mtbFriClose2.MaskInputRejected += mtbFriClose2_MaskInputRejected;
            // 
            // tableLayoutPanel_Thursday
            // 
            tableLayoutPanel_Thursday.BackColor = Color.White;
            tableLayoutPanel_Thursday.ColumnCount = 4;
            tableLayoutPanel_Thursday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Thursday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Thursday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Thursday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Thursday.Controls.Add(mtbThurOpen1, 0, 0);
            tableLayoutPanel_Thursday.Controls.Add(mtbThurClose1, 1, 0);
            tableLayoutPanel_Thursday.Controls.Add(mtbThurOpen2, 2, 0);
            tableLayoutPanel_Thursday.Controls.Add(mtbThurClose2, 3, 0);
            tableLayoutPanel_Thursday.Location = new Point(124, 167);
            tableLayoutPanel_Thursday.Name = "tableLayoutPanel_Thursday";
            tableLayoutPanel_Thursday.RowCount = 1;
            tableLayoutPanel_Thursday.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Thursday.Size = new Size(257, 28);
            tableLayoutPanel_Thursday.TabIndex = 3;
            tableLayoutPanel_Thursday.Paint += tableLayoutPanel_Thursday_Paint;
            // 
            // mtbThurOpen1
            // 
            mtbThurOpen1.Location = new Point(3, 3);
            mtbThurOpen1.Mask = "00:00";
            mtbThurOpen1.Name = "mtbThurOpen1";
            mtbThurOpen1.ShortcutsEnabled = false;
            mtbThurOpen1.Size = new Size(46, 29);
            mtbThurOpen1.TabIndex = 5;
            mtbThurOpen1.Tag = "      ";
            mtbThurOpen1.MaskInputRejected += mtbThurOpen1_MaskInputRejected;
            // 
            // mtbThurClose1
            // 
            mtbThurClose1.Location = new Point(67, 3);
            mtbThurClose1.Mask = "00:00";
            mtbThurClose1.Name = "mtbThurClose1";
            mtbThurClose1.ShortcutsEnabled = false;
            mtbThurClose1.Size = new Size(46, 29);
            mtbThurClose1.TabIndex = 5;
            mtbThurClose1.Tag = "      ";
            mtbThurClose1.MaskInputRejected += mtbThurClose1_MaskInputRejected;
            // 
            // mtbThurOpen2
            // 
            mtbThurOpen2.Location = new Point(131, 3);
            mtbThurOpen2.Mask = "00:00";
            mtbThurOpen2.Name = "mtbThurOpen2";
            mtbThurOpen2.ShortcutsEnabled = false;
            mtbThurOpen2.Size = new Size(46, 29);
            mtbThurOpen2.TabIndex = 5;
            mtbThurOpen2.Tag = "      ";
            mtbThurOpen2.MaskInputRejected += mtbThurOpen2_MaskInputRejected;
            // 
            // mtbThurClose2
            // 
            mtbThurClose2.Location = new Point(195, 3);
            mtbThurClose2.Mask = "00:00";
            mtbThurClose2.Name = "mtbThurClose2";
            mtbThurClose2.ShortcutsEnabled = false;
            mtbThurClose2.Size = new Size(46, 29);
            mtbThurClose2.TabIndex = 5;
            mtbThurClose2.Tag = "      ";
            mtbThurClose2.MaskInputRejected += mtbThurClose2_MaskInputRejected;
            // 
            // tableLayoutPanel_Wednesday
            // 
            tableLayoutPanel_Wednesday.BackColor = Color.White;
            tableLayoutPanel_Wednesday.ColumnCount = 4;
            tableLayoutPanel_Wednesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Wednesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Wednesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Wednesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Wednesday.Controls.Add(mtbWedOpen1, 0, 0);
            tableLayoutPanel_Wednesday.Controls.Add(mtbWedClose1, 1, 0);
            tableLayoutPanel_Wednesday.Controls.Add(mtbWedOpen2, 2, 0);
            tableLayoutPanel_Wednesday.Controls.Add(mtbWedClose2, 3, 0);
            tableLayoutPanel_Wednesday.Location = new Point(124, 133);
            tableLayoutPanel_Wednesday.Name = "tableLayoutPanel_Wednesday";
            tableLayoutPanel_Wednesday.RowCount = 1;
            tableLayoutPanel_Wednesday.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Wednesday.Size = new Size(257, 28);
            tableLayoutPanel_Wednesday.TabIndex = 3;
            tableLayoutPanel_Wednesday.Paint += tableLayoutPanel_Wednesday_Paint;
            // 
            // mtbWedOpen1
            // 
            mtbWedOpen1.Location = new Point(3, 3);
            mtbWedOpen1.Mask = "00:00";
            mtbWedOpen1.Name = "mtbWedOpen1";
            mtbWedOpen1.ShortcutsEnabled = false;
            mtbWedOpen1.Size = new Size(46, 29);
            mtbWedOpen1.TabIndex = 5;
            mtbWedOpen1.Tag = "      ";
            mtbWedOpen1.MaskInputRejected += mtbWedOpen1_MaskInputRejected;
            // 
            // mtbWedClose1
            // 
            mtbWedClose1.Location = new Point(67, 3);
            mtbWedClose1.Mask = "00:00";
            mtbWedClose1.Name = "mtbWedClose1";
            mtbWedClose1.ShortcutsEnabled = false;
            mtbWedClose1.Size = new Size(46, 29);
            mtbWedClose1.TabIndex = 5;
            mtbWedClose1.Tag = "      ";
            mtbWedClose1.MaskInputRejected += mtbWedClose1_MaskInputRejected;
            // 
            // mtbWedOpen2
            // 
            mtbWedOpen2.Location = new Point(131, 3);
            mtbWedOpen2.Mask = "00:00";
            mtbWedOpen2.Name = "mtbWedOpen2";
            mtbWedOpen2.ShortcutsEnabled = false;
            mtbWedOpen2.Size = new Size(46, 29);
            mtbWedOpen2.TabIndex = 5;
            mtbWedOpen2.Tag = "      ";
            mtbWedOpen2.MaskInputRejected += mtbWedOpen2_MaskInputRejected;
            // 
            // mtbWedClose2
            // 
            mtbWedClose2.Location = new Point(195, 3);
            mtbWedClose2.Mask = "00:00";
            mtbWedClose2.Name = "mtbWedClose2";
            mtbWedClose2.ShortcutsEnabled = false;
            mtbWedClose2.Size = new Size(46, 29);
            mtbWedClose2.TabIndex = 5;
            mtbWedClose2.Tag = "      ";
            mtbWedClose2.MaskInputRejected += mtbWedClose2_MaskInputRejected;
            // 
            // tableLayoutPanel_Monday
            // 
            tableLayoutPanel_Monday.BackColor = Color.White;
            tableLayoutPanel_Monday.ColumnCount = 4;
            tableLayoutPanel_Monday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Monday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Monday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Monday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Monday.Controls.Add(mtbMonOpen1, 0, 0);
            tableLayoutPanel_Monday.Controls.Add(mtbMonClose1, 1, 0);
            tableLayoutPanel_Monday.Controls.Add(mtbMonOpen2, 2, 0);
            tableLayoutPanel_Monday.Controls.Add(mtbMonClose2, 3, 0);
            tableLayoutPanel_Monday.Location = new Point(124, 65);
            tableLayoutPanel_Monday.Name = "tableLayoutPanel_Monday";
            tableLayoutPanel_Monday.RowCount = 1;
            tableLayoutPanel_Monday.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Monday.Size = new Size(257, 28);
            tableLayoutPanel_Monday.TabIndex = 3;
            tableLayoutPanel_Monday.Paint += tableLayoutPanel_Monday_Paint;
            // 
            // mtbMonOpen1
            // 
            mtbMonOpen1.Location = new Point(3, 3);
            mtbMonOpen1.Mask = "00:00";
            mtbMonOpen1.Name = "mtbMonOpen1";
            mtbMonOpen1.ShortcutsEnabled = false;
            mtbMonOpen1.Size = new Size(46, 29);
            mtbMonOpen1.TabIndex = 5;
            mtbMonOpen1.Tag = "      ";
            mtbMonOpen1.MaskInputRejected += mtbMonOpen1_MaskInputRejected;
            // 
            // mtbMonClose1
            // 
            mtbMonClose1.Location = new Point(67, 3);
            mtbMonClose1.Mask = "00:00";
            mtbMonClose1.Name = "mtbMonClose1";
            mtbMonClose1.ShortcutsEnabled = false;
            mtbMonClose1.Size = new Size(46, 29);
            mtbMonClose1.TabIndex = 5;
            mtbMonClose1.Tag = "      ";
            mtbMonClose1.MaskInputRejected += mtbMonClose1_MaskInputRejected;
            // 
            // mtbMonOpen2
            // 
            mtbMonOpen2.Location = new Point(131, 3);
            mtbMonOpen2.Mask = "00:00";
            mtbMonOpen2.Name = "mtbMonOpen2";
            mtbMonOpen2.ShortcutsEnabled = false;
            mtbMonOpen2.Size = new Size(46, 29);
            mtbMonOpen2.TabIndex = 5;
            mtbMonOpen2.Tag = "      ";
            mtbMonOpen2.MaskInputRejected += mtbMonOpen2_MaskInputRejected;
            // 
            // mtbMonClose2
            // 
            mtbMonClose2.Location = new Point(195, 3);
            mtbMonClose2.Mask = "00:00";
            mtbMonClose2.Name = "mtbMonClose2";
            mtbMonClose2.ShortcutsEnabled = false;
            mtbMonClose2.Size = new Size(46, 29);
            mtbMonClose2.TabIndex = 5;
            mtbMonClose2.Tag = "      ";
            mtbMonClose2.MaskInputRejected += mtbMonClose2_MaskInputRejected;
            // 
            // tableLayoutPanel_Tuesday
            // 
            tableLayoutPanel_Tuesday.BackColor = Color.White;
            tableLayoutPanel_Tuesday.ColumnCount = 4;
            tableLayoutPanel_Tuesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Tuesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Tuesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Tuesday.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Tuesday.Controls.Add(mtbTueOpen1, 0, 0);
            tableLayoutPanel_Tuesday.Controls.Add(mtbTueClose1, 1, 0);
            tableLayoutPanel_Tuesday.Controls.Add(mtbTueOpen2, 2, 0);
            tableLayoutPanel_Tuesday.Controls.Add(mtbTueClose2, 3, 0);
            tableLayoutPanel_Tuesday.Location = new Point(124, 99);
            tableLayoutPanel_Tuesday.Name = "tableLayoutPanel_Tuesday";
            tableLayoutPanel_Tuesday.RowCount = 1;
            tableLayoutPanel_Tuesday.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Tuesday.Size = new Size(257, 28);
            tableLayoutPanel_Tuesday.TabIndex = 3;
            tableLayoutPanel_Tuesday.Paint += tableLayoutPanel_Tuesday_Paint;
            // 
            // mtbTueOpen1
            // 
            mtbTueOpen1.Location = new Point(3, 3);
            mtbTueOpen1.Mask = "00:00";
            mtbTueOpen1.Name = "mtbTueOpen1";
            mtbTueOpen1.ShortcutsEnabled = false;
            mtbTueOpen1.Size = new Size(46, 29);
            mtbTueOpen1.TabIndex = 5;
            mtbTueOpen1.Tag = "      ";
            mtbTueOpen1.MaskInputRejected += mtbTueOpen1_MaskInputRejected;
            // 
            // mtbTueClose1
            // 
            mtbTueClose1.Location = new Point(67, 3);
            mtbTueClose1.Mask = "00:00";
            mtbTueClose1.Name = "mtbTueClose1";
            mtbTueClose1.ShortcutsEnabled = false;
            mtbTueClose1.Size = new Size(46, 29);
            mtbTueClose1.TabIndex = 5;
            mtbTueClose1.Tag = "      ";
            mtbTueClose1.MaskInputRejected += mtbTueClose1_MaskInputRejected;
            // 
            // mtbTueOpen2
            // 
            mtbTueOpen2.Location = new Point(131, 3);
            mtbTueOpen2.Mask = "00:00";
            mtbTueOpen2.Name = "mtbTueOpen2";
            mtbTueOpen2.ShortcutsEnabled = false;
            mtbTueOpen2.Size = new Size(46, 29);
            mtbTueOpen2.TabIndex = 5;
            mtbTueOpen2.Tag = "      ";
            mtbTueOpen2.MaskInputRejected += mtbTueOpen2_MaskInputRejected;
            // 
            // mtbTueClose2
            // 
            mtbTueClose2.Location = new Point(195, 3);
            mtbTueClose2.Mask = "00:00";
            mtbTueClose2.Name = "mtbTueClose2";
            mtbTueClose2.ShortcutsEnabled = false;
            mtbTueClose2.Size = new Size(46, 29);
            mtbTueClose2.TabIndex = 5;
            mtbTueClose2.Tag = "      ";
            mtbTueClose2.MaskInputRejected += mtbTueClose2_MaskInputRejected;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(721, 198);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(706, 198);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 0;
            // 
            // txtClinicName
            // 
            txtClinicName.Location = new Point(371, 79);
            txtClinicName.Name = "txtClinicName";
            txtClinicName.Size = new Size(193, 23);
            txtClinicName.TabIndex = 3;
            txtClinicName.TextChanged += textClinicName_TextChanged;
            // 
            // Save_setting
            // 
            Save_setting.BackColor = Color.FromArgb(0, 64, 64);
            Save_setting.ForeColor = Color.White;
            Save_setting.Location = new Point(777, 478);
            Save_setting.Name = "Save_setting";
            Save_setting.Size = new Size(75, 23);
            Save_setting.TabIndex = 4;
            Save_setting.Text = "Save";
            Save_setting.UseVisualStyleBackColor = false;
            Save_setting.Click += Save_setting_Click;
            // 
            // setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.HD_wallpaper_dentist_neon_icon_blue_background_neon_symbols_dentist_neon_icons_dentist_sign_medical_signs_dentist_icon_medical_icons;
            Controls.Add(Save_setting);
            Controls.Add(txtClinicName);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label1);
            Name = "setting";
            Size = new Size(886, 518);
            Load += setting_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel_Sunday.ResumeLayout(false);
            tableLayoutPanel_Sunday.PerformLayout();
            tableLayoutPanel_Saturday.ResumeLayout(false);
            tableLayoutPanel_Saturday.PerformLayout();
            tableLayoutPanel_Friday.ResumeLayout(false);
            tableLayoutPanel_Friday.PerformLayout();
            tableLayoutPanel_Thursday.ResumeLayout(false);
            tableLayoutPanel_Thursday.PerformLayout();
            tableLayoutPanel_Wednesday.ResumeLayout(false);
            tableLayoutPanel_Wednesday.PerformLayout();
            tableLayoutPanel_Monday.ResumeLayout(false);
            tableLayoutPanel_Monday.PerformLayout();
            tableLayoutPanel_Tuesday.ResumeLayout(false);
            tableLayoutPanel_Tuesday.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel_Sunday;
        private TableLayoutPanel tableLayoutPanel_Saturday;
        private TableLayoutPanel tableLayoutPanel_Friday;
        private TableLayoutPanel tableLayoutPanel_Thursday;
        private TableLayoutPanel tableLayoutPanel_Wednesday;
        private TableLayoutPanel tableLayoutPanel_Tuesday;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label13;
        private Label label15;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel_Monday;
        private TextBox txtClinicName;
        private Button Save_setting;
        private TextBox txtMonOpen1;
        private TextBox txtMonClose1;
        private TextBox txtMonOpen2;
        private TextBox txtMonClose2;
        private Button refresh_fields;
        private MaskedTextBox mtbMonOpen1;
        private MaskedTextBox mtbMonClose1;
        private MaskedTextBox mtbMonOpen2;
        private MaskedTextBox mtbMonClose2;
        private MaskedTextBox mtbSunOpen1;
        private MaskedTextBox mtbSunClose1;
        private MaskedTextBox mtbSatOpen1;
        private MaskedTextBox mtbSatClose1;
        private MaskedTextBox mtbFriOpen1;
        private MaskedTextBox mtbFriClose1;
        private MaskedTextBox mtbThurOpen1;
        private MaskedTextBox mtbThurClose1;
        private MaskedTextBox mtbWedOpen1;
        private MaskedTextBox mtbWedClose1;
        private MaskedTextBox mtbTueOpen1;
        private MaskedTextBox mtbTueClose1;
        private MaskedTextBox mtbTueOpen2;
        private MaskedTextBox mtbTueClose2;
        private MaskedTextBox mtbSunOpen2;
        private MaskedTextBox mtbSunClose2;
        private MaskedTextBox mtbSatOpen2;
        private MaskedTextBox mtbSatClose2;
        private MaskedTextBox mtbFriOpen2;
        private MaskedTextBox mtbFriClose2;
        private MaskedTextBox mtbThurOpen2;
        private MaskedTextBox mtbThurClose2;
        private MaskedTextBox mtbWedOpen2;
        private MaskedTextBox mtbWedClose2;
    }
}
