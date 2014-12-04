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
    }
}
