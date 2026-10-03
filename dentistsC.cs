using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DENTAL
{
    internal class dentistsC
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boss\OneDrive\Documents\DENTAL1.mdf;Integrated Security=True;Connect Timeout=30";

        public int DentistID { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Specialty { get; set; }
        public string CreatedAt { get; set; }

        // 1) Retrieve all Dentists from DB
        public List<dentistsC> listDentists()
        {
            List<dentistsC> listData = new List<dentistsC>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // E.g. retrieving some columns
                string selectData = @"SELECT DentistID, Name, Surname, Phone, Email,
                                             Gender, DOB, CreatedAt, Specialty
                                      FROM Dentists";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var d = new dentistsC
                            {
                                DentistID = (int)reader["DentistID"],
                                Name = reader["Name"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                DOB = (DateTime)reader["DOB"],
                                CreatedAt = ((DateTime)reader["CreatedAt"]).ToString("MM-dd-yyyy"),
                                Specialty = reader["Specialty"].ToString()
                            };
                            listData.Add(d);
                        }
                    }
                }
            }

            return listData;
        }
    }
} 