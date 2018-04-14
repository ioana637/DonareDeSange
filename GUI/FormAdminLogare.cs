using Service1;
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
    public partial class FormAdminLogare : Form
    {
        AdminService adminService;

        public FormAdminLogare(AdminService service)
        {
            InitializeComponent();
            this.adminService = service;
        
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username.Equals("") || password.Equals(""))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, "Trebuie sa completati ambele campuri", "Eroare!", buttons);
            }
            else
            {
                int result = adminService.Login(username, password);
                if (result >= 0)
                {
                    FormAdmin formMainView = new FormAdmin(adminService);
                    this.Hide();
                    formMainView.Closed += (s, args) => this.Close();
                    formMainView.ShowDialog();
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, "Parola sau usernameul invalid!", "Eroare!", buttons);
                }
            }

        }

       
    }
}
