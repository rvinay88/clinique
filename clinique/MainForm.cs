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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDoctor CreateDoctorForm = new CreateDoctor();
            this.Hide();
            CreateDoctorForm.Show();
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAppointment CreateAppointmentForm = new CreateAppointment();
            CreateAppointmentForm.Show();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRoom createRoom = new CreateRoom();
            createRoom.Show();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatePatient createPatient = new CreatePatient();
            createPatient.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cliniqueDBDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.cliniqueDBDataSet.appointment);
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointmentTableAdapter.FillBy(this.cliniqueDBDataSet.appointment);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
