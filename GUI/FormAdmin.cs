using CentruDeTransfuzie.utils;
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
    public partial class FormAdmin : Form
    {
        private AdminService adminService;
        private IList<CentruTransfuzie> listaCentreT = new List<CentruTransfuzie>();
        BindingSource bindingSourceCentre;
        private IList<Spital> listaSpitale = new List<Spital>();
        BindingSource bindingSourceSpitale;
        Judet judete = new Judet();

        public FormAdmin(AdminService adminService)
        {
            InitializeComponent();
            this.adminService = adminService;
            loadDataGridViewCentreT();
            loadJudete();
            loadDataGridViewSpitale();
            loadComboBoxCentreTranfuzii();

        }

        private void loadComboBoxCentreTranfuzii()
        {
            foreach (CentruTransfuzie c in listaCentreT)
            {
                comboBoxCentruT.Items.Add(c);
            }
        }

        private void loadDataGridViewSpitale()
        {
            listaSpitale = adminService.GetAllSpitale();
            bindingSourceSpitale = new BindingSource(listaSpitale, null);
            dataGridViewSpitale.DataSource = bindingSourceSpitale;
            if (bindingSourceSpitale.Position >= 0)
            {
                dataGridViewSpitale.Rows[bindingSourceSpitale.Position].Selected = true;
            }
        }

        private void loadJudete()
        {
            foreach (var i in judete.judet.Keys)
            {
                comboBoxJudet.Items.Add(i.ToString());
                comboBoxJudetSpital.Items.Add(i.ToString());
            }
        }

        private void loadDataGridViewCentreT()
        {
            listaCentreT = adminService.GetAllCentre();
            bindingSourceCentre = new BindingSource(listaCentreT, null);
            dataGridViewCentre.DataSource = bindingSourceCentre;
            if (bindingSourceCentre.Position >= 0)
            {
                dataGridViewCentre.Rows[bindingSourceCentre.Position].Selected = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormAdminLogare formAdminLogare = new FormAdminLogare(adminService);
            this.Hide();
            formAdminLogare.Closed += (s, args) => this.Close();
            formAdminLogare.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingSourceCentre.Position >= 0)
            {
                dataGridViewCentre.Rows[bindingSourceCentre.Position].Selected = true;
            }
        }

        private void buttonAddCentruT_Click(object sender, EventArgs e)
        {
            //add centru transfuzie
            string nume, parola, adresa, judet, localitate;
            nume = textBoxNume.Text;
            adresa = textBoxAdresa.Text;
            parola = textBoxParola.Text;

            if (comboBoxJudet.SelectedIndex >= 0 && comboBoxLocalitate.SelectedIndex >= 0)
            {
                judet = comboBoxJudet.Items[comboBoxJudet.SelectedIndex].ToString();
                localitate = comboBoxLocalitate.Items[comboBoxLocalitate.SelectedIndex].ToString();

                if (nume.Equals("") || parola.Equals("") || adresa.Equals(""))
                {
                    MessageBox.Show(this, "Campuri necompletate!", "Error!");
                }
                else
                {
                    //adaugare 
                    CentruTransfuzie centru = new CentruTransfuzie(nume, adresa, localitate, judet, parola);
                    adminService.AddCentru(centru);
                    loadDataGridViewCentreT();
                }
            }
            else
            {
                MessageBox.Show(this, "Campuri necompletate!", "Error!");
            }

        }

        private void comboBoxJudet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLocalitate.Items.Clear();

            int index = comboBoxJudet.SelectedIndex;
            var key = comboBoxJudet.Items[index];

            List<string> vector = new List<string>();
            judete.judet.TryGetValue(key.ToString(), out vector);

            if (judete.judet.ContainsKey(key.ToString()))
            {
                foreach (var i in vector)
                {
                    comboBoxLocalitate.Items.Add(i);
                }
            }
        }

        private void buttonDeleteCentru_Click(object sender, EventArgs e)
        {
            if (bindingSourceCentre.Position >= 0)
            {
                CentruTransfuzie centruTransfuzie = listaCentreT[bindingSourceCentre.Position];
                adminService.Delete(centruTransfuzie);
                MessageBox.Show(this, "Centru de transfuzie a fost sters cu succes!", "Informatie");
                loadDataGridViewCentreT();
            }
            else
            {
                MessageBox.Show(this, "Va rugam selectati un centru pentru a il sterge!", "Eroare");
            }
        }




        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //addSpital NU MERGE!!!

            string adresa = textBoxAdresaSpital.Text;
            string judet, localitate;
            CentruTransfuzie centru;

            if (comboBoxJudetSpital.SelectedIndex >= 0 && comboBoxLocalitateSpital.SelectedIndex >= 0
                && comboBoxCentruT.SelectedIndex >= 0)
            {
                judet = comboBoxJudetSpital.Items[comboBoxJudetSpital.SelectedIndex].ToString();
                localitate = comboBoxLocalitateSpital.Items[comboBoxLocalitateSpital.SelectedIndex].ToString();
                centru = (CentruTransfuzie) comboBoxCentruT.Items[comboBoxCentruT.SelectedIndex];

                if (adresa.Equals(""))
                {
                    MessageBox.Show(this, "Campuri necompletate!", "Error!");
                }
                else
                {
                    //adminService.AddSpital(new Spital(centru,adresa, localitate, judet));
                    loadDataGridViewSpitale();

                }
            }
            else
            {
                MessageBox.Show(this, "Campuri necompletate!", "Error!");
            }
        }

        private void comboBoxJudetSpital_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLocalitateSpital.Items.Clear();

            int index = comboBoxJudetSpital.SelectedIndex;
            var key = comboBoxJudetSpital.Items[index];

            List<string> vector = new List<string>();
            judete.judet.TryGetValue(key.ToString(), out vector);

            if (judete.judet.ContainsKey(key.ToString()))
            {
                foreach (var i in vector)
                {
                    comboBoxLocalitateSpital.Items.Add(i);
                }
            }
        }
    }
}
