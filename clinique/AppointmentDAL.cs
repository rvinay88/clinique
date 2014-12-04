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

        public int RemoveRoomAvailability(string RoomNumber, string Date, string Time)
        {
            int result = 0;

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "RemoveRoomAvailability";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Parameters.AddWithValue("@RoomNumber", RoomNumber);
            mySqlCommand.Parameters.AddWithValue("@Date", Date);
            mySqlCommand.Parameters.AddWithValue("@Time", Time);
            result = mySqlCommand.ExecuteNonQuery();

            return result;
        }

        public int RemoveDoctorAvailability(string DoctorName, string Date, string Time)
        {
            int result = 0;

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "RemoveDoctorAvailability";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Parameters.AddWithValue("@DoctorName", DoctorName);
            mySqlCommand.Parameters.AddWithValue("@Date", Date);
            mySqlCommand.Parameters.AddWithValue("@Time", Time);
            result = mySqlCommand.ExecuteNonQuery();

            return result;
        }
    }
}
