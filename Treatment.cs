using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing; 
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace DENTAL
{
    public partial class Treatment : UserControl  
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        private int appointmentId;
        private string patientName;
        private string dentistName;
        private float totalAmount = 0f;
        private string clinicName = "Default Clinic"; 

        private bool exitConfirmationShown = false; 
        private bool doneConfirmationShown = false; 
        private bool printPreviewOpen = false; 

        public Treatment()
        {
            InitializeComponent(); 

            ClearButton.Click += ClearButton_Click;
            AddRowButton.Click += AddRowButton_Click;
            ExitButton.Click += ExitButton_Click;
            DoneButton.Click += DoneButton_Click;
            ViewReceiptButton.Click += ViewReceiptButton_Click;
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                clinicName = LoadClinicNameFromDB();

                SetupInitialBillingTable();
            }
        }

        public void SetData(int apptId, string patName, string docName)
        {
            appointmentId = apptId;
            patientName = patName;
            dentistName = docName;

            AppIDLabel.Text = appointmentId.ToString();
            PatientNameLabel.Text = patientName;
            DentistNameLabel.Text = dentistName;

            ConsultationNote.Text = "";
            Prescriptions.Text = "";

            SetupInitialBillingTable();
        }

        private void SetupInitialBillingTable()
        {
            BillingTable.Controls.Clear();
            BillingTable.RowStyles.Clear();
            BillingTable.RowCount = 0;

            totalAmount = 0f;
            TotalLabel.Text = "0.00";

            AddBillingRow();
        }

        private void AddBillingRow()
        {
            int rowIndex = BillingTable.RowCount;
            BillingTable.RowCount++;
            BillingTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            TextBox descBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Name = "Description_" + rowIndex
            };
            BillingTable.Controls.Add(descBox, 0, rowIndex);

            TextBox amtBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Name = "Amount_" + rowIndex,
                Text = "$"
            };
            amtBox.TextChanged += (s, e) => RecalcTotal();
            amtBox.Enter += (s, e) =>
            {
                if (amtBox.Text.StartsWith("$"))
                {
                    amtBox.Text = amtBox.Text.Substring(1).Trim();
                }
            };
            amtBox.Leave += (s, e) =>
            {
                string raw = amtBox.Text.Replace("$", "").Trim();
                if (float.TryParse(raw, out float val))
                {
                    amtBox.Text = $"${val:0.00}";
                }
            };

            BillingTable.Controls.Add(amtBox, 1, rowIndex);
        }

        private void RecalcTotal()
        {
            float sum = 0f;
            foreach (Control ctrl in BillingTable.Controls)
            {
                if (ctrl is TextBox tb && tb.Name.StartsWith("Amount_"))
                {
                    string raw = tb.Text.Replace("$", "").Trim();
                    if (float.TryParse(raw, out float val))
                        sum += val;
                }
            }
            totalAmount = sum;
            TotalLabel.Text = $"$ {totalAmount:0.00}";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetupInitialBillingTable();
        }
        private void AddRowButton_Click(object sender, EventArgs e)
        {
            AddBillingRow();
        }

        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (exitConfirmationShown)
            {
                ReturnToAppointments();
                return;
            }

            bool hasData = (BillingTable.RowCount > 1
                            || !string.IsNullOrWhiteSpace(GetCellText(0, 0))
                            || !string.IsNullOrWhiteSpace(GetCellText(1, 0)));
            bool hasNote = !string.IsNullOrWhiteSpace(ConsultationNote.Text);
            bool hasRx = !string.IsNullOrWhiteSpace(Prescriptions.Text);

            if (hasData || hasNote || hasRx)
            {
                exitConfirmationShown = true;
                var dr = MessageBox.Show(
                    "You have unsaved changes. Are you sure you want to exit?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (dr == DialogResult.No)
                {
                    exitConfirmationShown = false;
                    return;
                }
            }
            ReturnToAppointments();
        }

        private string GetCellText(int col, int row)
        {
            var ctrl = BillingTable.GetControlFromPosition(col, row) as TextBox;
            return ctrl?.Text ?? "";
        }

        private void ReturnToAppointments()
        {
            var mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {
                this.Visible = false;
                mainForm.ShowAppointments();
            }
            else
            {
                if (this.Parent != null)
                    this.Parent.Controls.Remove(this);
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (doneConfirmationShown)
            {
                return;
            }
            doneConfirmationShown = true;

            var dr = MessageBox.Show(
                "Finish this treatment? ",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dr == DialogResult.No)
            {
                doneConfirmationShown = false;
                return;
            }

            if (!AppointmentExistsInDB(appointmentId))
            {
                MessageBox.Show("Error: The appointment no longer exists in the database.",
                                "Foreign Key Conflict",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DeleteOldTreatmentReferences();

            InsertTreatmentRow();

            int newlyInsertedTreatmentID = GetNewestTreatmentID();
            if (newlyInsertedTreatmentID > 0 && totalAmount > 0f)
            {
                InsertRevenueRecord(newlyInsertedTreatmentID, DateTime.Today, (decimal)totalAmount);
            }

            DeleteAppointment();

            MessageBox.Show("Treatment saved and appointment deleted.");

            DoneButton.Enabled = false;

            ReturnToAppointments();
        }

        private bool AppointmentExistsInDB(int apptID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Appointments WHERE AppointmentID=@id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", apptID);
                    int count = (int)cmd.ExecuteScalar();
                    return (count > 0);
                }
            }
        }

        private void DeleteOldTreatmentReferences()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Treatments WHERE AppointmentID=@aid";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@aid", appointmentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void InsertTreatmentRow()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                  INSERT INTO Treatments (AppointmentID, PatientName, DentistName, TotalAmount)
                  VALUES (@aid, @pname, @dname, @tot)
                ";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@aid", appointmentId);
                    cmd.Parameters.AddWithValue("@pname", patientName);
                    cmd.Parameters.AddWithValue("@dname", dentistName);
                    cmd.Parameters.AddWithValue("@tot", totalAmount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteAppointment()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Appointments WHERE AppointmentID=@id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        private void ViewReceiptButton_Click(object sender, EventArgs e)
        {
            if (!printPreviewOpen)
            {
                printPreviewOpen = true;
                PrintReceipt();
                printPreviewOpen = false;
            }
        }

        private void PrintReceipt()
        {
            var doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document = doc;
                preview.Width = 800;
                preview.Height = 600;
                preview.ShowDialog();
            }
        }

        private string LoadClinicNameFromDB()
        {
            string cName = "Default Clinic";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ClinicName FROM ClinicSettings WHERE SettingsID=1";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        object obj = cmd.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                            cName = obj.ToString();
                    }
                }
            }
            catch
            {
               
            }
            return cName;
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float pageWidth = e.PageBounds.Width;
            float marginLeft = 50f;
            float marginRight = 50f;
            float yPos = 50f;
            float lineHeight = 28f;

            using (Font clinicFont = new Font("Arial", 20, FontStyle.Bold))
            using (Font labelFont = new Font("Arial", 14, FontStyle.Bold))
            using (Font normalFont = new Font("Arial", 12, FontStyle.Regular))
            {
                var centerFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near
                };
                RectangleF topRect = new RectangleF(0, yPos, pageWidth, lineHeight * 2);

                e.Graphics.DrawString(
                    "DIAMOND \"DENTAL CLINIC\"",
                    clinicFont,
                    Brushes.DarkOliveGreen,
                    topRect,
                    centerFormat
                );
                yPos += (lineHeight * 2) + 10;

                float leftColumnX = marginLeft;
                float rightColumnX = pageWidth - marginRight - 200;

                e.Graphics.DrawString(
                    $"Patient: {patientName}",
                    normalFont,
                    Brushes.Black,
                    leftColumnX,
                    yPos
                );

                e.Graphics.DrawString(
                    $"Doctor: {dentistName}",
                    normalFont,
                    Brushes.Black,
                    rightColumnX,
                    yPos
                );
                yPos += lineHeight * 2;

                e.Graphics.DrawString("Billing Details:", labelFont, Brushes.Black, marginLeft, yPos);
                yPos += lineHeight;

                for (int row = 0; row < BillingTable.RowCount; row++)
                {
                    TextBox descCtrl = BillingTable.GetControlFromPosition(0, row) as TextBox;
                    TextBox amtCtrl = BillingTable.GetControlFromPosition(1, row) as TextBox;
                    if (descCtrl != null && amtCtrl != null)
                    {
                        string desc = descCtrl.Text.Trim();
                        string amt = amtCtrl.Text.Replace("$", "").Trim();

                        if (!string.IsNullOrEmpty(desc) || !string.IsNullOrEmpty(amt))
                        {
                            e.Graphics.DrawString(
                                $"{desc}: ${amt}",
                                normalFont,
                                Brushes.Black,
                                marginLeft + 25f,
                                yPos
                            );
                            yPos += lineHeight;
                        }
                    }
                }

                yPos += lineHeight;
                e.Graphics.DrawString("Consultation Note:", labelFont, Brushes.Black, marginLeft, yPos);
                yPos += lineHeight;
                e.Graphics.DrawString(
                    ConsultationNote.Text ?? "",
                    normalFont,
                    Brushes.Black,
                    marginLeft + 25f,
                    yPos
                );
                yPos += lineHeight * 2;

                e.Graphics.DrawString("Prescriptions:", labelFont, Brushes.Black, marginLeft, yPos);
                yPos += lineHeight;
                e.Graphics.DrawString(
                    Prescriptions.Text ?? "",
                    normalFont,
                    Brushes.Black,
                    marginLeft + 25f,
                    yPos
                );
                yPos += lineHeight * 2;

                e.Graphics.DrawString(
                    $"TOTAL: {TotalLabel.Text}",
                    clinicFont,
                    Brushes.Black,
                    rightColumnX,
                    yPos
                );
            }
        }

        
        private int GetNewestTreatmentID()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT MAX(TreatmentID) FROM Treatments";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object obj = cmd.ExecuteScalar();
                    if (obj == null || obj == DBNull.Value)
                        return 0;
                    return Convert.ToInt32(obj);
                }
            }
        }

        
        private void InsertRevenueRecord(int treatmentID, DateTime revDate, decimal amount)
        {
            string sql = @"
                INSERT INTO RevenueRecords (RevenueDate, Amount, TreatmentID)
                VALUES (@rd, @amt, @tid);
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rd", revDate.Date);
                    cmd.Parameters.AddWithValue("@amt", amount);
                    cmd.Parameters.AddWithValue("@tid", treatmentID);
                    cmd.ExecuteNonQuery();
                }
            } 
        }
    }
}
