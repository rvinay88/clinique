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
    public partial class CreateDoctor : Form
    {
        public CreateDoctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) {

                Doctor doctor1 = new Doctor(txtDoctorName.Text, txtDoctorPhone.Text, txtSpecialization.Text, txtEmployment.Text);

                DoctorDAL dDAL = new DoctorDAL(ConfigurationManager.ConnectionStrings["CliniqueDB"].ConnectionString);

                int result = 0;

                try
                {
                    dDAL.OpenConnection();
                    result = dDAL.CreateDoctor(doctor1);
                    if (result == -1)
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
                    dDAL.CloseConnection();

                    txtSpecialization.Clear();
                    txtEmployment.Clear();
                    txtDoctorPhone.Clear();
                    txtDoctorName.Clear();
                }                
            }
        }

        private bool ValidateForm()
        {
            int val = 0;
            if (!(txtEmployment.Text == "FullTime" || txtEmployment.Text == "PartTime"))
            {
                val = -1;
                CreateDoctorErrorProvider.SetError(txtEmployment, "This value has to be either PartTime or FullTime");
                CreateDoctorErrorProvider.BlinkRate = 0;
            }
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
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
