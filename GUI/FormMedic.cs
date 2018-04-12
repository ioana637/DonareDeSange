using CentruDeTransfuzie1.utils;
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
        public FormMedic(UserMedicService service, String username)
        {
            InitializeComponent();
            this.serviceMedic = service;
            this.usernameMedic = username;
            initComboGrupa();
            initComboRh();
            Refresh();

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
        }
        private void initCampuri()
        {
            textBoxGlobule.Text = "";
            textBoxPlasma.Text = "";
            textBoxTotal.Text = "";
            textBoxTrombocite.Text = "";
            Console.WriteLine("aici");
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRH.SelectedItem == null||comboBoxGrupa.SelectedItem==null) throw new Exception("Trebuie selectata grupa si Rh-ul!");

                if (comboBoxGrupa.Enabled)
                {
                    Cerere cerere = BuildCerereSave();
                    serviceMedic.AddCerere(cerere, usernameMedic);
                }
                else
                {
                    Cerere cerere = BuildCerereUpdate();
                    serviceMedic.UpdateCerere(cerere);
                }
                tabControl1.SelectedTab = tabPage2;
                Refresh();

            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Eroare!", MessageBoxButtons.OK);
            }
        
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
                comboBoxGrupa.SelectedItem =row.Cells[8].Value.ToString();
                comboBoxRH.SelectedItem = row.Cells[9].Value.ToString();
                comboBoxRH.Enabled = false;
                comboBoxGrupa.Enabled = false;
                textBoxGlobule.Text = row.Cells[5].Value.ToString();
                textBoxPlasma.Text = row.Cells[6].Value.ToString();
                textBoxTotal.Text = row.Cells[3].Value.ToString();
                textBoxTrombocite.Text= row.Cells[4].Value.ToString();
                textBoxTotal.Enabled = true;
                tabControl1.SelectedTab = tabPage3;




            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Eroare!", MessageBoxButtons.OK); }
        }
    }
}
