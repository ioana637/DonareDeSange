﻿using CentruDeTransfuzie.model;
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
    public partial class FormLogareMedic : Form
    {
        private UserMedicService serviceMedic;

        public FormLogareMedic(UserMedicService service)
        {
            InitializeComponent();
            serviceMedic = service;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username, parola;
            username = textBoxUsername.Text;
            parola = textBoxPassword.Text;

            if (username.Equals("") || username.Equals(""))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, "Trebuie sa completati ambele campuri", "Eroare!", buttons);
            }
            else
            {
                int result = serviceMedic.Login(username, parola);
                if (result>=0)
                {
                    Form formMainView = new FormMedic(serviceMedic, result,username);
                    this.Hide();

                    formMainView.Closed += (s, args) => this.Close();
                    formMainView.ShowDialog();
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, "Usernameul sau parola au fost introduse gresit!", "Eroare!", buttons);
                }
            }
        }

        private void FormLogareMedic_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Parolă")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Parolă";
                textBoxPassword.ForeColor = Color.Silver;
            }
        }
    }
}
