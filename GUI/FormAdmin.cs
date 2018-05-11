using CentruDeTransfuzie.utils;
using Service1;
using System;
using System.Collections.Generic;
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
        private IList<Medic> listaMedici = new List<Medic>();
        BindingSource bindingSourceMedici;
        Judet judete = new Judet();

        public FormAdmin(AdminService adminService)
        {
            InitializeComponent();
            this.adminService = adminService;
            loadDataGridViewCentreT();
            loadJudete();
            loadDataGridViewSpitale();
            loadComboBoxCentreTranfuzii();
            loadDataGrdViewMedici();
            initListaSpitalePaginaMedic();
        }

        private void initListaSpitalePaginaMedic()
        {
            checkedListBoxListSpitale.Items.Clear();
            foreach (Spital sp in adminService.GetAllSpitale())
            {
                //DE CE NU MERGEEE!!!???
                Console.WriteLine(sp.ToString());
                checkedListBoxListSpitale.Items.Add(new Object());
            }
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
                dataGridViewSpitale.Rows[bindingSourceSpitale.Position].Selected = true;
            dataGridViewSpitale.Columns[1].Visible = false;
            //dataGridViewSpitale.Columns.Add("NumeCentruTransfuzie", "NumeCentruTransfuzie");
            //dataGridViewSpitale.Columns["NumeCentruTransfuzie"].ReadOnly = true;

            //dataGridViewSpitale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           
        }

        private void loadDataGrdViewMedici()
        {

            listaMedici = adminService.GetAllMedici();
            bindingSourceMedici = new BindingSource(listaMedici, null);
            dataGridViewMedici.DataSource = bindingSourceMedici;
            dataGridViewMedici_CellClick(this, new DataGridViewCellEventArgs(0, 0));
            dataGridViewMedici.Columns["UserMedic"].Visible = false;

            //dataGridViewMedici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
            dataGridViewCentre.AutoResizeColumns();
            listaCentreT = adminService.GetAllCentre();
            bindingSourceCentre = new BindingSource(listaCentreT, null);
            dataGridViewCentre.DataSource = bindingSourceCentre;
            if (bindingSourceCentre.Position >= 0)
            {
                dataGridViewCentre.Rows[bindingSourceCentre.Position].Selected = true;
            }

            dataGridViewCentre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

            string adresa = textBoxAdresaSpital.Text;
            string judet, localitate;
            CentruTransfuzie centru;

            if (comboBoxJudetSpital.SelectedIndex >= 0 && comboBoxLocalitateSpital.SelectedIndex >= 0
                && comboBoxCentruT.SelectedIndex >= 0)
            {
                judet = comboBoxJudetSpital.Items[comboBoxJudetSpital.SelectedIndex].ToString();
                localitate = comboBoxLocalitateSpital.Items[comboBoxLocalitateSpital.SelectedIndex].ToString();
                centru = (CentruTransfuzie)comboBoxCentruT.Items[comboBoxCentruT.SelectedIndex];

                if (adresa.Equals(""))
                {
                    MessageBox.Show(this, "Campuri necompletate!", "Error!");
                }
                else
                {
                    adminService.AddSpital(new Spital(centru, adresa, localitate, judet), centru);
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

        private void buttonDeleteSpital_Click(object sender, EventArgs e)
        {
            Spital spital = listaSpitale[bindingSourceCentre.Position];
            adminService.DeleteSpital(spital);
            loadDataGridViewSpitale();
        }

        private void dataGridViewSpitale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingSourceSpitale.Position >= 0)
            {
                dataGridViewSpitale.Rows[bindingSourceSpitale.Position].Selected = true;
            }
        }

        private void dataGridViewSpitale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSpitale_CellClick(sender, e);
        }

        private void dataGridViewMedici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingSourceMedici.Position >= 0)
            {
                dataGridViewMedici.Rows[bindingSourceMedici.Position].Selected = true;
            }
            incarcareTextBoxuriCuUser();
        }

        private void incarcareTextBoxuriCuUser()
        {
            UserMedic user = adminService.GetUserMedicByMedic(listaMedici[bindingSourceMedici.Position]);
            textBoxUsernameMedic.Text = user.Username;
            textBoxPasswordMedic.Text = user.Parola;

        }

        private void dataGridViewMedici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMedici_CellClick(sender, e);
        }

        private void buttonDeleteMedic_Click(object sender, EventArgs e)
        {
            //Delete a medic with Usermedic
            Medic medic = listaMedici[bindingSourceMedici.Position];
            UserMedic userMedic = adminService.GetUserMedicByMedic(medic);
            adminService.DeleteMedicAndUser(medic, userMedic);
            loadDataGrdViewMedici();
        }

        private void buttonAddMedic_Click(object sender, EventArgs e)
        {
            String cnp = textBoxCNPMedic.Text;
            String nume = textBoxNumeMedic.Text;
            String prenume = textBoxPrenumeMedic.Text;
            String telefon = textBoxTelefonMedic.Text;
            String email = textBoxEmailMedic.Text;
            String parola = textBoxPasswordMedic.Text;
            String username = textBoxUsernameMedic.Text;

            bool valid = validareCampuriMedic(cnp,nume,prenume,telefon,email,parola,username);
            if (!valid)
            {
                MessageBox.Show(this, "Campuri necompletate!", "Error!");
                return; 
            }

            Medic medic = new Medic(cnp, nume, prenume, email, telefon);
            UserMedic user = new UserMedic(username, parola);
            adminService.AddMedic(medic, user, new List<Spital>());
            loadDataGrdViewMedici();
        }

        private bool validareCampuriMedic(string cnp, string nume, string prenume, string telefon, string email, string parola, string username)
        {
            if (cnp.Equals("") || nume.Equals("") || prenume.Equals("") || telefon.Equals("") ||
                email.Equals("") || parola.Equals("") || username.Equals(""))
                return false;

            return true;

        }
    }
}
