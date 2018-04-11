using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace GUI
{
    public partial class FormLogareDonator : Form
    {
        DonatorService service = new DonatorService();

        public FormLogareDonator(DonatorService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterDonator formRegister = new FormRegisterDonator();
            formRegister.Show();
        }

        private void buttonLogIn2_Click(object sender, EventArgs e)
        {
            try
            {
                UserDonator user = service.GetUserDonator(txtUsername.Text);
                if (user.Username == txtUsername.Text && user.Parola == txtPassw.Text)
                {
                    FormDonator formDonator = new FormDonator();
                    formDonator.Show();
                }
                else
                {
                    MessageBox.Show("Username or password incorect!!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Username or password incorect!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
