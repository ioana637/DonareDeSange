using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDonator : Form
    {
        public FormDonator()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogareDonator formLogareDonator = new FormLogareDonator(new DonatorService());
            formLogareDonator.Show();
            this.Hide();
        }
    }
}
