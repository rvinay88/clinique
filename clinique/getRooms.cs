using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace clinique
{
    class getRooms
    {

        public string Date { get; private set; }
        public string Time { get; private set; }

        public getRooms(string date, string time)
        {
            Date = date;
            Time = time;
        }
        public String[] GetRoomProc(getRooms gr)
        {
            String[] result1 = new String[10];
            int i = 0;

            SqlConnection mySqlConnection1 = null;
            mySqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CliniqueDB"].ConnectionString);

            mySqlConnection1.Open();

            SqlCommand mySqlCommand = new SqlCommand();
            mySqlCommand.CommandText = "GetRooms";
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlCommand.Connection = mySqlConnection1;
            mySqlCommand.Parameters.AddWithValue("@Date", gr.Date);
            mySqlCommand.Parameters.AddWithValue("@Time", gr.Time);
            SqlDataReader myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                result1[i++] = myReader["RoomID"].ToString().Trim();
            }
            mySqlConnection1.Close();
            return result1;
        }
    }
}
