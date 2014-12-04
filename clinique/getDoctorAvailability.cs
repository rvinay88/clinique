using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace clinique
{
    class getDoctorAvailability
    {
        string Date;
        string DoctorName;

        public getDoctorAvailability(string date, string doctorName)
        {
            Date = date;
            DoctorName = doctorName;
        }

        public string[] getAvailabilityProc(getDoctorAvailability gd)
        {
            String[] result1 = new String[100];
            int i = 0;

            SqlConnection mySqlConnection1 = null;
            mySqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CliniqueDB"].ConnectionString);

            mySqlConnection1.Open();

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "GetDoctorTimings";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection1;
            mySqlCommand.Parameters.AddWithValue("@Date", gd.Date);
            mySqlCommand.Parameters.AddWithValue("@DoctorName", gd.DoctorName);
            SqlDataReader myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                result1[i++] = myReader["Time"].ToString().Trim();
            }
            mySqlConnection1.Close();
            return result1;
        }
    }
}
