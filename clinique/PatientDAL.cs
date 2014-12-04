using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace clinique
{
    class PatientDAL
    {
        SqlConnection mySqlConnection = null;
        public PatientDAL(string connectionString)
        {
            mySqlConnection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            mySqlConnection.Open();
        }

        public void CloseConnection()
        {
            mySqlConnection.Close();
        }

        public int CreatePatient(Patient patient2)
        {
            int result = 0;

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "CreatePatient";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Parameters.AddWithValue("@PatientName", patient2.PatientName);
            mySqlCommand.Parameters.AddWithValue("@PatientPhone", patient2.PatientPhone);
            mySqlCommand.Parameters.AddWithValue("@PatientIssue", patient2.PatientIssue);
            result = mySqlCommand.ExecuteNonQuery();
            
            return result;
        }
    }
}
