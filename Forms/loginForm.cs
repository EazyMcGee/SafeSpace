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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            models.RoomBookingEntities roomBookingEntities = new models.RoomBookingEntities();

            if (tb_userName.Text != String.Empty && tb_password.Text != String.Empty)
            {
                var user = roomBookingEntities.loginINFOes.Where(table => table.Username.Equals(tb_userName.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(tb_password.Text))
                    {
                        MessageBox.Show("Login Admin");
                        this.Hide();
                        Form mainForm = new mainForm();
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Username & Password");
            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
