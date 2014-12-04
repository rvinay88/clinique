using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace clinique
{
    class AppointmentDAL
    {
        SqlConnection mySqlConnection = null;

        public AppointmentDAL(string connectionString) {
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

        public int CreateAppointment(Appointment appointment2)
        {
            int result = 0;

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "CreateAppointment";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Parameters.AddWithValue("@PatientName", appointment2.PatientName);
            mySqlCommand.Parameters.AddWithValue("@PatientNumber", appointment2.PatientNumber);
            mySqlCommand.Parameters.AddWithValue("@DoctorName", appointment2.DoctorName);
            mySqlCommand.Parameters.AddWithValue("@AppointmentDate", appointment2.AppointmentDate);
            mySqlCommand.Parameters.AddWithValue("@AppointmentTime", appointment2.AppointmentTime);
            mySqlCommand.Parameters.AddWithValue("@RoomNumber", appointment2.RoomNumber);
            result = mySqlCommand.ExecuteNonQuery();
            
            return result;
        }
    }
}
