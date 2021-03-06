﻿using System;
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
        DonatorService service;

        public FormLogareDonator(DonatorService service)
        {
            InitializeComponent();
            this.service = service;
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
                //UserDonator user = service.GetUserDonator(txtUsername.Text);
                if (service.LogInUserDonator(txtUsername.Text,txtPassw.Text))
                {
                    FormDonator formDonator = new FormDonator(service, txtUsername.Text);
                    this.Hide();
                    formDonator.Closed += (s, args) => this.Close();
                    formDonator.Show();
                    if (DonatorService.NeedsToBeNotified(service.GetUserDonator(txtUsername.Text).Id))
                    {
                        MessageBox.Show("E nevoie de sangele tau!!! Sangele tau poate salva vieti. Doneaza acum");
                    }
                    
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

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassw_Enter(object sender, EventArgs e)
        {
            if (txtPassw.Text == "Parolă")
            {
                txtPassw.Text = "";
                txtPassw.ForeColor = Color.Black;
                txtPassw.UseSystemPasswordChar = true;
            }
        }

        private void txtPassw_Leave(object sender, EventArgs e)
        {
            if (txtPassw.Text == "")
            {
                txtPassw.UseSystemPasswordChar = false;
                txtPassw.Text = "Parolă";
                txtPassw.ForeColor = Color.Silver;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
