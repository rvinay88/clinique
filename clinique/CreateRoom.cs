using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinique
{
    public partial class CreateRoom : Form
    {
        private int val;

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
                
            }
        }

        private bool ValidateForm()
        {
            if (txtRoomID.Text.Trim().Length == 0)
            {
                val = -1;
                CreateRoomErrorProvider.SetError(txtRoomID, "This field cannot be empty");
                CreateRoomErrorProvider.BlinkRate = 0;
            }
            if (txtRoomName.Text.Trim().Length == 0)
            {
                val = -1;
                CreateRoomErrorProvider.SetError(txtRoomName, "This field cannot be empty");
                CreateRoomErrorProvider.BlinkRate = 0;
            }
            if (val < 1)
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
