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
        Judet judete = new Judet();

        public FormAdmin(AdminService adminService)
        {
            InitializeComponent();
            this.adminService = adminService;
            loadDataGridViewCentreT();
            loadJudete();
        }

        private void loadJudete()
        {
            foreach (var i in judete.judet.Keys)
            {
                comboBoxJudet.Items.Add(i.ToString());
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

            if (comboBoxJudet.SelectedIndex >= 0 && comboBoxLocalitate.SelectedIndex>=0)
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
                    CentruTransfuzie centru = new CentruTransfuzie(nume, adresa, localitate, judet,parola);
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
            //delete un centru selectat
        }
    }
}
