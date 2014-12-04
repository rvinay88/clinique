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
    public partial class CreateAppointment : Form
    {
        public CreateAppointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string theDate = dtpAppointmentDate.Value.ToShortDateString();
                Appointment appointment1 = new Appointment(txtPatientName.Text, txtPatientNumber.Text, txtDoctorName.Text, theDate, txtAppointmentTime.Text, txtRoomNumber.Text);

                AppointmentDAL aDAL = new AppointmentDAL(ConfigurationManager.ConnectionStrings["CliniqueDB"].ConnectionString);

                int result = 0;

                try
                {
                    aDAL.OpenConnection();
                    result = aDAL.CreateAppointment(appointment1);
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
                    aDAL.CloseConnection();

                    txtPatientName.Clear();
                    txtPatientNumber.Clear();
                    txtDoctorName.Clear();
                    txtAppointmentTime.Clear();
                    txtRoomNumber.Clear();
                }  
            }
        }

        private bool ValidateForm()
        {
            return true;
        }
    }
}
