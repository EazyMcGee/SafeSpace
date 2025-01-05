using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBookingSystem
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void makeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form safetyQuestions = new safety();
            safetyQuestions.ShowDialog();
        }

        private void cancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cancelingForm = new cancelForm();
            cancelingForm.ShowDialog();
        }

        private void mainForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form loginForm = new loginForm();
            loginForm.ShowDialog();
        }
    }
}