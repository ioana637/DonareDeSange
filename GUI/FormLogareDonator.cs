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
        private DonatorService serviceDonator = new DonatorService();
        public FormLogareDonator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterDonator formRegisterDonator = new FormRegisterDonator();
            this.Hide();
            formRegisterDonator.Closed += (s, args) => this.Close();
            formRegisterDonator.ShowDialog();
        }
    }
}
