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

namespace RoomBookingSystem
{
    public partial class safety : Form
    {
        public safety()
        {
            InitializeComponent();
        }

        private void safety_Load(object sender, EventArgs e)
        {
            btnDone.Enabled = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form bookingForm = new bookingForm();
            bookingForm.ShowDialog();
        }

        private void rb12_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked && rb6.Checked && rb8.Checked && rb10.Checked && rb12.Checked)
            {
                btnDone.Enabled = true;
            }
        }
    }
}
