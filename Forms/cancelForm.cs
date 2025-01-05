using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomBookingSystem.models;

namespace RoomBookingSystem
{
    public partial class cancelForm : Form
    {
        public cancelForm()
        {
            InitializeComponent();
        }

        private void cancelBooking_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record? ", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    models.RoomBookingEntities db = new models.RoomBookingEntities();
                    
                    bookingINFO cancelling = new bookingINFO { firstName = tbName.Text };
                    db.bookingINFOes.Attach(cancelling);
                    db.bookingINFOes.Remove(cancelling);
                    db.SaveChanges();
                    dgvBookings.Update();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cancelForm_Load(object sender, EventArgs e)
        {
            models.RoomBookingEntities db = new models.RoomBookingEntities();
            var bookings = db.bookingINFOes.ToList();
            dgvBookings.DataSource = bookings;
        }

        private void searchBooking_Click(object sender, EventArgs e)
        {
            models.RoomBookingEntities search = new models.RoomBookingEntities();
            var items = search.bookingINFOes.Where(a => a.firstName.Equals(tbName.Text)).ToList();
            dgvBookings.DataSource = items;
        }

        private void cancelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form mainForm = new mainForm();
            mainForm.ShowDialog();
        }
    }
}
