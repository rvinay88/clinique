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
    public partial class CreateDoctor : Form
    {
        public CreateDoctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) { }
        }

        private bool ValidateForm()
        {
            int val = 0;

            if (txtDoctorName.Text == "")
            {
                val = -1;
                CreateDoctorErrorProvider.SetError(txtDoctorName, "This value cannot be empty");
                CreateDoctorErrorProvider.BlinkRate = 0;
            }

            if (txtDoctorPhone.Text == "")
            {
                val = -1;
                CreateDoctorErrorProvider.SetError(txtDoctorPhone, "This value cannot be empty");
                CreateDoctorErrorProvider.BlinkRate = 0;
            }

            if (txtEmployment.Text == "")
            {
                val = -1;
                CreateDoctorErrorProvider.SetError(txtEmployment, "This value cannot be empty");
                CreateDoctorErrorProvider.BlinkRate = 0;
            }

            if (txtSpecialization.Text == "")
            {
                val = -1;
                CreateDoctorErrorProvider.SetError(txtSpecialization, "This value cannot be empty");
                CreateDoctorErrorProvider.BlinkRate = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
