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
    public partial class FormLogareMedic : Form
    {
        public FormLogareMedic()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBoxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxUsername.Text = "";
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            
        }
    }
}
