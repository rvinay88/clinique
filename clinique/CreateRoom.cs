using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace clinique
{
    public partial class CreateRoom : Form
    {
        private int val = 0;

        public CreateRoom()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Room room1 = new Room(int.Parse(txtRoomID.Text), txtRoomName.Text);

                roomDAL rDAL = new roomDAL(ConfigurationManager.ConnectionStrings["CliniqueDB"].ConnectionString);

                int result = 0;

                try
                {
                    rDAL.OpenConnection();
                    result = rDAL.CreateRoom(room1);
                    if (result == 1)
                    {
                        MessageBox.Show("Successfully Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    rDAL.CloseConnection();
                }

                //return result;


            }
        }

        private bool ValidateForm()
        {
            if (txtRoomID.Text.Length == 0)
            {
                val = -1;
                CreateRoomErrorProvider.SetError(txtRoomID, "This field cannot be empty");
                CreateRoomErrorProvider.BlinkRate = 0;
            }
            if (txtRoomName.Text.Length == 0)
            {
                val = -1;
                CreateRoomErrorProvider.SetError(txtRoomName, "This field cannot be empty");
                CreateRoomErrorProvider.BlinkRate = 0;
            }
            if (val < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
