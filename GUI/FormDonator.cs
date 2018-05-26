using CentruDeTransfuzie.model;
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
            FormLogareDonator formLogareDonator = new FormLogareDonator(service);
            formLogareDonator.Show();
            this.Hide();
            formLogareDonator.Closed += (s, args) => this.Close();


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
            cmbJud.SelectedItem = donator.Judet;
            cmbLoc.SelectedItem = donator.Localitate;
            textBoxAdresaR.Text = donator.Resedinta != "" ? donator.Resedinta : donator.Domiciliu;
            cmbJudR.SelectedItem = donator.JudetResedinta != "" ? donator.JudetResedinta : donator.Judet;
            cmbLocR.SelectedItem = donator.LocalitateResedinta != "" ? donator.LocalitateResedinta : donator.Localitate;
            textTelefon.Text = donator.Telefon;
            textEmail.Text = donator.Email;
            if (donator.Sex == "F")
            {
                checkBoxInsarcinata.Visible = true;
            }
            else
            {
                checkBoxInsarcinata.Visible = false;
            }
            if (donator.Greutate > 50)
            {
                checkBoxGreutate.Checked = true;
            }
            if (donator.InterventiiUltimele6Luni == 1)
            {
                checkBoxInterventii.Checked = true;
            }
            if (donator.SubTratament == 1)
            {
                checkBoxTratament.Checked = true;
            }
            LoadCereriSange();
            LoadAnalizeDonator();

        }

        private void LoadCereriSange()
        {
            List<Cerere> cereriSange = service.GetAllCereriByIdDonator(Username);
            BindingSource bindingSource = new BindingSource(cereriSange, null);
            dataGridViewCereri.DataSource = cereriSange;
            dataGridViewCereri.Columns["Id"].Visible = false;
            dataGridViewCereri.Columns["CantitateGlobuleRosii"].Visible = false;
            dataGridViewCereri.Columns["CantitatePlasma"].Visible = false;
            dataGridViewCereri.Columns["CantitateTrombocite"].Visible = false;
            dataGridViewCereri.Columns["Medic"].Visible = false;
            dataGridViewCereri.Columns["Grupa"].Visible = false;
            dataGridViewCereri.Columns["RH"].Visible = false;

        }

        private void LoadAnalizeDonator()
        {
            List<Analiza> listaAnalize = service.GetAllAnalizeByIdDonator(Username);
            BindingSource bindingSource = new BindingSource(listaAnalize, null);
            dataGridViewAnalize.DataSource = listaAnalize;
            dataGridViewAnalize.Columns["Id"].Visible = false;
            dataGridViewAnalize.Columns["Donator"].Visible = false;
            dataGridViewAnalize.Columns["PungaSange"].Visible = false;
            dataGridViewAnalize.Columns["NivelALT"].Visible = false;
        }

        private void cmbJudR_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLocR.Text = string.Empty;
            cmbLocR.Items.Clear();

            int index = cmbJudR.SelectedIndex;
            var key = cmbJudR.Items[index];

            List<string> vector = new List<string>();
            judet.judet.TryGetValue(key.ToString(), out vector);

            if (judet.judet.ContainsKey(key.ToString()))
            {
                bool ok = true;

                foreach (var i in vector)
                {
                    if (ok != true)
                    {
                        cmbLocR.Items.Add(i);
                    }
                    else
                    {
                        ok = false;
                    }
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
                bool ok = true;

                foreach (var i in vector)
                {
                    if (ok != true)
                    {
                        cmbLoc.Items.Add(i);
                    }
                    else
                    {
                        ok = false;
                    }
                }
            }
        }

        private void buttonVreauSaDonez_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (checkBoxInsarcinata.Checked == true)
            {
                message += "! sunteti insarcinata";
            }
            if (checkBoxGreutate.Checked == false)
            {
                message += "! greutatea minimă admisă este de 50 kg";
            }
            if (checkBoxInterventii.Checked == true)
            {
                message += "! ați avut intervenții în ultimele 6 luni";
            }
            if (checkBoxTratament.Checked == true)
            {
                message += "! sunteți sub tratament";
            }
            if (checkBoxBoala.Checked == true)
            {
                message += "! sunteți suferind de boală";
            }

            if (checkBoxConditii.Checked == false)
            {
                message += "! nu ați fost de acord cu condițiile dinaintea donării";
            }

            var mesaj = message.Split('!');

            string messageToShow = string.Empty;

            foreach (var i in mesaj)
            {
                if (i != "")
                {
                    if (messageToShow == string.Empty)
                    {
                        messageToShow += $"Ne pare rau, dar nu puteti dona deoarece:  ";
                    }
                    messageToShow += i + ",  ";
                }
            }


            Donator donator = service.GetDonator(Username);
            if (checkBoxInterventii.Checked)
            {
                donator.InterventiiUltimele6Luni = 1;
            }
            else
            {
                donator.InterventiiUltimele6Luni = 0;
            }
            if (checkBoxTratament.Checked)
            {
                donator.SubTratament = 1;
            }
            else
            {
                donator.SubTratament = 0;
            }
            service.UpdateDonator(donator);

            if (messageToShow == string.Empty)
            {
                MessageBox.Show("Mulțumim pentru dorința de a ajuta. Vă așteptăm la cel mai apropiat centru de colectare");
            }
            else
            {
                MessageBox.Show(messageToShow);
            }
        }

    }
}
