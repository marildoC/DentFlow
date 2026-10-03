using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 
using System.Text.RegularExpressions; 
using BCrypt.Net;
// using System.Xml.Linq;

namespace DENTAL
{
    public partial class patientForm : UserControl
    {
        private patientC patientLogic = new patientC();


        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public patientForm()
        {
            InitializeComponent();
           
        } 

       
        private void InitializeDataGridView()
        {
            
        }

        private void LoadPatientData()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    



    private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }


    }

}
