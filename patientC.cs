using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DENTAL  
{  


    internal class patientC
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public int PatientID { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CreatedAt { get; set; }

        public List<patientC> listPatientC()
        {
            List<patientC> listData = new List<patientC>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectData = "SELECT PatientID, Name, Surname, Phone, Email, CreatedAt FROM Patients";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pc = new patientC
                            {
                                PatientID = (int)reader["PatientID"],
                                Name = reader["Name"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString(),
                                CreatedAt = ((DateTime)reader["CreatedAt"]).ToString("MM-dd-yyyy"),
                            };
                            listData.Add(pc);
                        }
                    }
                }
            }

            return listData;
        }
    }
}  

