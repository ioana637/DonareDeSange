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
    public partial class FormMedic : Form
    {
        private UserMedicService serviceMedic;
        private string usernameMedic;
        private List<Cerere> listCereri = new List<Cerere>();
        private BindingSource bindingSource;
        private int idMedicCurent;
        private List<Pacient> listPacienti = new List<Pacient>();
        private BindingSource bindingSourceP;

        public FormMedic(UserMedicService service, int idMedic, string username)
        {
            InitializeComponent();
            this.serviceMedic = service;
            this.idMedicCurent = idMedic;
            this.usernameMedic = username;
            initComboGrupa();
            initComboRh();
            initComboPr();
            initPacienti();
            Refresh();
            loadDataGridView1();
            //createDataGridView1();

        }

        private void Refresh()
        {
            //createDataGridView2();
            loadDataGridView2();


            initCampuri();
            //createDataGridView2();
            loadDataGridView2();
            comboBoxGrupa.Enabled = true;
            comboBoxRH.Enabled = true;
            comboBoxGrupa.SelectedItem = null;
            comboBoxRH.SelectedItem = null;
            Pacienti.SelectedItems.Clear();
        }
        private void initCampuri()
        {
            textBoxGlobule.Text = "";
            textBoxPlasma.Text = "";
            textBoxTotal.Text = "";
            textBoxTrombocite.Text = "";
            Console.WriteLine("aici");
        }

        private void initPacienti()
        {
            Pacienti.Items.Clear();
            List<Pacient> pacienti = serviceMedic.GetPacientByMedic(idMedicCurent);
            pacienti.ForEach(p => Pacienti.Items.Add(p.Nume));
            
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogareMedic formLogareMedic = new FormLogareMedic(serviceMedic);
            this.Hide();
            formLogareMedic.Closed += (s, args) => this.Close();
            formLogareMedic.ShowDialog();
        }

        private void createDataGridView2()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "Id";
            colId.DataPropertyName = "Id";

            DataGridViewTextBoxColumn colCantitateSange = new DataGridViewTextBoxColumn();
            colId.Name = "CantitateSange";
            colId.HeaderText = "Cantitate Sange";
            colId.DataPropertyName = "Cantitate Sange";

            DataGridViewTextBoxColumn colCantitateGlobuleRosii = new DataGridViewTextBoxColumn();
            colId.Name = "CantitateGlobuleRosii";
            colId.HeaderText = "Cantitate Globule Rosii";
            colId.DataPropertyName = "Cantitate Globule Rosii";

            DataGridViewTextBoxColumn colCantitateTrombocite = new DataGridViewTextBoxColumn();
            colId.Name = "CantitateTrombocite";
            colId.HeaderText = "Cantitate Trombocite";
            colId.DataPropertyName = "Cantitate Trombocite";

            DataGridViewTextBoxColumn colCantitatePlasma = new DataGridViewTextBoxColumn();
            colId.Name = "CantitatePlasma";
            colId.HeaderText = "Cantitate Plasma";
            colId.DataPropertyName = "Cantitate Plasma";

            DataGridViewTextBoxColumn colEfectuata = new DataGridViewTextBoxColumn();
            colId.Name = "Efectuata";
            colId.HeaderText = "Efectuata";
            colId.DataPropertyName = "Efectuata";

            DataGridViewTextBoxColumn colData = new DataGridViewTextBoxColumn();
            colId.Name = "Data";
            colId.HeaderText = "Data";
            colId.DataPropertyName = "Data";

            dataGridView2.Columns.Add(colId);
            dataGridView2.Columns.Add(colCantitateSange);
            dataGridView2.Columns.Add(colCantitateGlobuleRosii);
            dataGridView2.Columns.Add(colCantitateTrombocite);
            dataGridView2.Columns.Add(colCantitatePlasma);
            dataGridView2.Columns.Add(colEfectuata);
            dataGridView2.Columns.Add(colData);

        }

        private void loadDataGridView2()
        {
            listCereri = serviceMedic.GetCereriByMedic(usernameMedic);
            bindingSource = new BindingSource(listCereri, null);
            dataGridView2.DataSource = bindingSource;
            if (bindingSource.Position >= 0)
            {
                dataGridView2.Rows[bindingSource.Position].Selected = true;
            }
            dataGridView2.Columns[1].Visible = false;

        }

        private void initComboRh()
        {
            comboBoxRH.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRH.Items.Add(TipRh.Pozitiv.ToString());
            comboBoxRH.Items.Add(TipRh.Negativ.ToString());
        }

        private void initComboGrupa()
        {
            comboBoxGrupa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrupa.Items.Add(GrupaSange.OI.ToString());
            comboBoxGrupa.Items.Add(GrupaSange.AII.ToString());
            comboBoxGrupa.Items.Add(GrupaSange.BIII.ToString());
            comboBoxGrupa.Items.Add(GrupaSange.ABIV.ToString());
        }

        private void initComboPr()
        {
            comboBoxPr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPr.Items.Add(GradUrgenta.Scăzut.ToString());
            comboBoxPr.Items.Add(GradUrgenta.Mediu.ToString());
            comboBoxPr.Items.Add(GradUrgenta.Ridicat.ToString());

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRH.SelectedItem == null || comboBoxGrupa.SelectedItem == null||comboBoxPr==null) throw new Exception("Trebuie selectata grupa, Rh-ul si gradul de urgenta!");

                if (comboBoxGrupa.Enabled)
                {
                    Cerere cerere = BuildCerereSave();
                    serviceMedic.AddCerere(cerere, usernameMedic, GetPacientiSelectati());
                }
                else
                {
                    Cerere cerere = BuildCerereUpdate();
                    serviceMedic.UpdateCerere(cerere);
                }
                tabControl1.SelectedTab = tabPage2;
                Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Eroare!", MessageBoxButtons.OK);
            }

        }

        private List<Pacient> GetPacientiSelectati()
        {
            List<Pacient> pacienti = new List<Pacient>();
            foreach (object item in Pacienti.CheckedItems)
            {
                pacienti.Add(serviceMedic.GetPacientByMedic(idMedicCurent).Where(p => p.Nume.Equals(item)).FirstOrDefault());
            }
            return pacienti;
        }
        private Cerere BuildCerereUpdate()
        {
            Cerere cerere = new Cerere();
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            cerere.Id = Int32.Parse(row.Cells[0].Value.ToString());
            Int32 total, plasma, trombocite, globule;
            if (textBoxTotal.Enabled)
            {
                total = Int32.Parse(textBoxTotal.Text);
                cerere.CantitateSange = total;

            }
            else
            {
                plasma = Int32.Parse(textBoxPlasma.Text);
                trombocite = Int32.Parse(textBoxTrombocite.Text);
                globule = Int32.Parse(textBoxGlobule.Text);
                total = plasma + trombocite + globule;
                cerere.CantitateGlobuleRosii = globule;
                cerere.CantitatePlasma = plasma;
                cerere.CantitateTrombocite = trombocite;
                cerere.CantitateSange = total;

            }
            return cerere;
        }

        private Cerere BuildCerereSave()
        {
            Cerere cerere = new Cerere();
            cerere.Data = DateTime.Now.Date.ToShortDateString();
            cerere.Efectuata = false;
            TipRh RH = (TipRh)Enum.Parse(typeof(TipRh), comboBoxRH.Text);
            GrupaSange grupa = (GrupaSange)Enum.Parse(typeof(GrupaSange), comboBoxGrupa.Text);
            cerere.Grupa = grupa;
            cerere.RH = RH;
            Int32 total, plasma, trombocite, globule;
           
            


            if (textBoxTotal.Enabled)
            {
                total = Int32.Parse(textBoxTotal.Text);
                cerere.CantitateSange = total;

            }

            else
            {
                plasma = Int32.Parse(textBoxPlasma.Text);
                trombocite = Int32.Parse(textBoxTrombocite.Text);
                globule = Int32.Parse(textBoxGlobule.Text);
                total = plasma + trombocite + globule;
                cerere.CantitateGlobuleRosii = globule;
                cerere.CantitatePlasma = plasma;
                cerere.CantitateTrombocite = trombocite;
                cerere.CantitateSange = total;

            }

            return cerere;
        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTotal.Text == "")
            {
                textBoxGlobule.Enabled = true;
                textBoxPlasma.Enabled = true;
                textBoxTrombocite.Enabled = true;
            }
            else
            {
                textBoxGlobule.Enabled = false;
                textBoxPlasma.Enabled = false;
                textBoxTrombocite.Enabled = false;
            }

        }

        private void textBoxPlasma_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTrombocite.Text == "" && textBoxGlobule.Text == "" && textBoxPlasma.Text == "")
                textBoxTotal.Enabled = true;
            else textBoxTotal.Enabled = false;
        }

        private void textBoxGlobule_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTrombocite.Text == "" && textBoxGlobule.Text == "" && textBoxPlasma.Text == "")
                textBoxTotal.Enabled = true;
            else textBoxTotal.Enabled = false;
        }

        private void textBoxTrombocite_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTrombocite.Text == "" && textBoxGlobule.Text == "" && textBoxPlasma.Text == "")
                textBoxTotal.Enabled = true;
            else textBoxTotal.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string value1 = row.Cells[0].Value.ToString();
            try
            {
                if (!dataGridView2.CurrentRow.Selected) throw new Exception("Trebuie selectat tot randul");
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                if ((bool)row.Cells[7].Value) throw new Exception("Cererea a fost tratata deja!");
                comboBoxGrupa.SelectedItem = row.Cells[8].Value.ToString();
                comboBoxRH.SelectedItem = row.Cells[9].Value.ToString();
                comboBoxRH.Enabled = false;
                comboBoxGrupa.Enabled = false;
                textBoxGlobule.Text = row.Cells[5].Value.ToString();
                textBoxPlasma.Text = row.Cells[6].Value.ToString();
                textBoxTotal.Text = row.Cells[3].Value.ToString();
                textBoxTrombocite.Text = row.Cells[4].Value.ToString();
                textBoxTotal.Enabled = true;
                tabControl1.SelectedTab = tabPage3;




            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Eroare!", MessageBoxButtons.OK); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //adaugarePACIENT
            try
            {
                #region Date Pacient
                string Nume = txtNume.Text;
                string Prenume = txtPrenume.Text;
                string Email = txtEmail.Text;
                int idMedic = idMedicCurent;
                bool esteDonator;

                if (checkDonator.Checked == true)
                {
                    esteDonator = true;
                }
                else
                {
                    esteDonator = false;
                }

                if (Nume.Equals("") || Prenume.Equals("") || Email.Equals(""))
                {
                    throw new ValidationException();
                }

                #endregion

                serviceMedic.AdaugaPacient(idMedic, Nume, Prenume, Email, esteDonator);
                loadDataGridView1();
                initPacienti();

                #region ClearFieldsAddPacient
                txtNume.Text = "";
                txtPrenume.Text = "";
                txtEmail.Text = "";
                checkDonator.Checked = false;
                #endregion


            }
            catch (Exception error)
            {
                MessageBox.Show("Date invalide! Pacientul nu poate fi adaugat!\n" + error.Message);
            }
        }

        private void createDataGridView1()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "Id";
            colId.DataPropertyName = "Id";

            DataGridViewTextBoxColumn colEsteDonator = new DataGridViewTextBoxColumn();
            colId.Name = "Este Donator";
            colId.HeaderText = "Este Donator";
            colId.DataPropertyName = "Este Donator";

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colId.Name = "Email";
            colId.HeaderText = "Email";
            colId.DataPropertyName = "Email";

            DataGridViewTextBoxColumn colNume = new DataGridViewTextBoxColumn();
            colId.Name = "Nume";
            colId.HeaderText = "Nume";
            colId.DataPropertyName = "Nume";

            DataGridViewTextBoxColumn colPrenume = new DataGridViewTextBoxColumn();
            colId.Name = "Prenume";
            colId.HeaderText = "Prenume";
            colId.DataPropertyName = "Prenume";


            dataGridView1.Columns.Add(colId);
            dataGridView1.Columns.Add(colEsteDonator);
            dataGridView1.Columns.Add(colEmail);
            dataGridView1.Columns.Add(colNume);
            dataGridView1.Columns.Add(colPrenume);

        }

        private void loadDataGridView1()
        {
            listPacienti = serviceMedic.GetPacientByMedic(idMedicCurent);
            bindingSourceP = new BindingSource(listPacienti, null);
            dataGridView1.DataSource = bindingSourceP;
            if (bindingSourceP.Position >= 0)
            {
                dataGridView1.Rows[bindingSourceP.Position].Selected = true;
                
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;


        }

        private void Pacienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}