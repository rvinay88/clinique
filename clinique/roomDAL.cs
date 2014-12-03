using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace clinique
{
    class roomDAL
    {
        SqlConnection mySqlConnection = null;
        public roomDAL(string connectionString)
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

        public int CreateRoom(Room room)
        {
            int result = 0;

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "CreateRoom";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Parameters.AddWithValue("@roomID", room.RoomID);
            mySqlCommand.Parameters.AddWithValue("@roomName", room.RoomName);
            result = mySqlCommand.ExecuteNonQuery();
            
            return result;
        }
    }
}
