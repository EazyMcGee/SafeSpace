using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using RoomBookingSystem.models;

namespace RoomBookingSystem
{
    public partial class bookingForm : Form
    {
        public bookingForm()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is ComboBox)
                        (control as ComboBox).Text = "";
                    else
                    {
                        func(control.Controls);
                    }
            };
            func(Controls);
        }

        private void makeABooking_Click(object sender, EventArgs e)
        {
            var isComboboxEmpty = scanForControls<ComboBox>(this).Where(x => x.SelectedIndex < 0).Any();

            if (isComboboxEmpty)
            {
                MessageBox.Show("Please fill in all fields");
            }
            try
            {
                models.RoomBookingEntities db = new models.RoomBookingEntities();

                bookingINFO booking = new bookingINFO
                {
                    startTime = cbStartTime.Text,
                    endTime = cbEndTime.Text,
                    totalMembers = Convert.ToInt32(cbMembers.Text),
                    roomOptions = cbRoomOption.Text,
                    firstName = tbForename.Text,
                    lastName = tbSurname.Text,
                    Description = rtbDescription.Text,
                    date = Convert.ToDateTime(dtpBookingDate.Text)
                };
                db.bookingINFOes.Add(booking);
                db.SaveChanges();
                MessageBox.Show("Booking successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookingForm_Load(object sender, EventArgs e)
        {

        }

        //error validation comboboxes
        public IEnumerable<T> scanForControls<T>(Control bookingForm) where T : Control
        {
            if (bookingForm is T)
                yield return (T)bookingForm;

            foreach (Control combobox in bookingForm.Controls)
            {
                foreach (var combobox1 in scanForControls<T>(combobox))
                    yield return combobox1;
            }
        }

        private void bookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form mainForm = new mainForm();
            mainForm.ShowDialog();
        }
    }
}
