using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace clinique
{
    class DoctorDAL
    {
        SqlConnection mySqlConnection = null;

        public DoctorDAL(string connectionString) {
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

        public int CreateDoctor(Doctor doctor2)
        {
            int result = 0;

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "CreateDoctor";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Parameters.AddWithValue("@DoctorName", doctor2.DoctorName);
            mySqlCommand.Parameters.AddWithValue("@DoctorPhone", doctor2.DoctorPhone);
            mySqlCommand.Parameters.AddWithValue("@Specialization", doctor2.Specialization);
            mySqlCommand.Parameters.AddWithValue("@Employment", doctor2.Employment.ToString());
            result = mySqlCommand.ExecuteNonQuery();
            
            return result;
        }
    }
}
