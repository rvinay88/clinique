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
    public partial class CreatePatient : Form
    {
        public CreatePatient()
        {
            InitializeComponent();
        }

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                Patient patient1 = new Patient(txtPatientName.Text, txtPatientNumber.Text, txtHealthIssue.Text);

                PatientDAL pDAL = new PatientDAL(ConfigurationManager.ConnectionStrings["CliniqueDB"].ConnectionString);

                int result = 0;

                try
                {
                    pDAL.OpenConnection();
                    result = pDAL.CreatePatient(patient1);
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
                    pDAL.CloseConnection();

                    txtPatientName.Clear();
                    txtPatientNumber.Clear();
                    txtHealthIssue.Clear();
                }
            }
        }

        private bool ValidateForm()
        {
            return true;
        }
    }
}
