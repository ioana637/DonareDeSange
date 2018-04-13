using CentruDeTransfuzie.utils;
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
        DonatorService service;
        Judet judet = new Judet();
        string Username { get; set; }

        public FormDonator(DonatorService service, string username)
        {
            InitializeComponent();
            this.service = service;
            this.Username = username;

            foreach (var i in judet.judet.Keys)
            {
                cmbJud.Items.Add(i.ToString());
                cmbJudR.Items.Add(i.ToString());
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogareDonator formLogareDonator = new FormLogareDonator(new DonatorService());
            formLogareDonator.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Donator donator = service.GetDonator(Username);
            UserDonator user = service.GetUserDonator(Username);
            string message = string.Empty;

            if (textBoxUserName.Text != null && textBoxUserName.Text != "")
            {
                if (textBoxUserName.Text != user.Username)
                {
                    try
                    {
                        service.GetUserDonator(textBoxUserName.Text);
                        message += ",username";
                    }
                    catch (Exception ex)
                    {
                        user.Username = textBoxUserName.Text;
                    }
                }
            }
            else
            {
                message += ",username";
            }
            if (textBoxSetariNume.Text != null && textBoxSetariNume.Text != "")
            {
                donator.Nume = textBoxSetariNume.Text;
            }
            else
            {
                message += ",nume";
            }
            if (textBoxSetariPrenume.Text != null && textBoxSetariPrenume.Text != "")
            {
                donator.Prenume = textBoxSetariPrenume.Text;
            }
            else
            {
                message += ",prenume";
            }
            if (textAdresa.Text != null && textAdresa.Text != "")
            {
                donator.Domiciliu = textAdresa.Text;
            }
            else
            {
                message += ",adresa";
            }
            if (cmbLoc.Text != null && cmbLoc.Text != "")
            {
                donator.Localitate = cmbLoc.Text;
            }
            else
            {
                message += ",localitate";
            }
            if (cmbJud.Text != null && cmbJud.Text != "")
            {
                donator.Judet = cmbJud.Text;
            }
            else
            {
                message += ",judet";
            }
            if (textEmail.Text != null && textEmail.Text != "" && textEmail.Text.Contains("@") && textEmail.Text.Contains("."))
            {
                donator.Email = textEmail.Text;
            }
            else
            {
                message += ",E-mail";
            }
            try
            {
                Int64.Parse(textTelefon.Text);
                if (donator.Telefon != textTelefon.Text)
                {
                    donator.Telefon = textTelefon.Text;
                }
            }
            catch (Exception ex)
            {
                message += ",telefon";
            }

            if (service.Encrypt(textBoxParola.Text) == user.Parola)
            {
                if (textPswNew.Text == textPswNewR.Text)
                {
                    user.Parola = service.Encrypt(textPswNew.Text);
                }
            }

            if (message == string.Empty)
            {
                service.UpdateDonator(donator);
                service.UpdateUserDonator(user);
                this.Username = textBoxUserName.Text;
                MessageBox.Show("Modificarile au avut loc cu succes");
                textBoxParola.Clear();
                textPswNew.Clear();
                textPswNewR.Clear();
            }
            else
            {
                MessageBox.Show($"Am gasit probleme la: {message}");
                var msg = message.Split(',');
                foreach (var i in msg)
                {
                    switch (i)
                    {
                        case "username":
                            textBoxUserName.Text = user.Username;
                            break;
                        case "nume":
                            textBoxSetariNume.Text = donator.Nume;
                            break;
                        case "prenume":
                            textBoxSetariPrenume.Text = donator.Prenume;
                            break;
                        case "adresa":
                            textAdresa.Text = donator.Domiciliu;
                            break;
                        case "judet":
                            cmbJud.Text = donator.Judet;
                            break;
                        case "localitate":
                            cmbLoc.Text = donator.Localitate;
                            break;
                        case "telefon":
                            textTelefon.Text = donator.Telefon;
                            break;
                        case "E-mail":
                            textEmail.Text = donator.Email;
                            break;
                    }
                }
            }
        }

        private void FormDonator_Load(object sender, EventArgs e)
        {
            Donator donator = service.GetDonator(this.Username);
            UserDonator user = service.GetUserDonator(this.Username);
            textBoxUserName.Text = user.Username;
            textBoxSetariNume.Text = donator.Nume;
            textBoxSetariPrenume.Text = donator.Prenume;
            textAdresa.Text = donator.Domiciliu;
            cmbLoc.Text = donator.Localitate;
            cmbJud.Text = donator.Judet;
            cmbJudR.Text = donator.JudetResedinta;
            cmbLocR.Text = donator.LocalitateResedinta;
            textTelefon.Text = donator.Telefon;
            textEmail.Text = donator.Email;

        }

        private void cmbJudR_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLocR.Text = string.Empty;

            int index = cmbJudR.SelectedIndex;
            var key = cmbJudR.Items[index];

            List<string> vector = new List<string>();
            judet.judet.TryGetValue(key.ToString(), out vector);

            if (judet.judet.ContainsKey(key.ToString()))
            {
                foreach (var i in vector)
                {
                    cmbLocR.Items.Clear();
                    cmbLocR.Items.Add(i);
                }
            }
        }

        private void cmbJud_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLoc.Text = string.Empty;
            cmbLoc.Items.Clear();

            int index = cmbJud.SelectedIndex;
            var key = cmbJud.Items[index];

            List<string> vector = new List<string>();
            judet.judet.TryGetValue(key.ToString(), out vector);

            if (judet.judet.ContainsKey(key.ToString()))
            {
                foreach (var i in vector)
                {
                    cmbLoc.Items.Add(i);
                }
            }
        }
    }
}
