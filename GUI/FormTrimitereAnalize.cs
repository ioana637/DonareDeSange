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
    public partial class FormTrimitereAnalize : Form
    {
        private CentruService service;
        private Donator donator;
        public FormTrimitereAnalize(CentruService service, Donator donator)
        {
            this.donator = donator;
            this.service = service;
            InitializeComponent();
        }

        private bool ValidateForm() {
            if (comboBoxGrupaSange.SelectedItem != null && 
                comboBoxRh.SelectedItem != null && 
                int.Parse(textBoxNivelALT.Text) > 0 && 
                comboBoxPunga.SelectedItem != null)
                return true;
            return false;
        }
        private void buttonTrimite_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //try
                //{
                    service.AddAnaliza((GrupaSange)comboBoxGrupaSange.SelectedItem, (TipRh)comboBoxRh.SelectedItem, checkBoxHIV.Checked, checkBoxHepatitaB.Checked, checkBoxHepatitaC.Checked, checkBoxSifilis.Checked, checkBoxHTLV.Checked, int.Parse(textBoxNivelALT.Text), (PungaSange)comboBoxPunga.SelectedItem, donator);
                    comboBoxGrupaSange.SelectedItem = null;
                    comboBoxRh.SelectedItem = null;
                    textBoxNivelALT.Text = null;
                    comboBoxPunga.SelectedItem = null;
                //}catch(Exception e)
                //{
                //    MessageBox
                //}
            }
            else
                MessageBox.Show("Trebuie sa completati toate datele!");
        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FormTrimitereAnalize_Load(object sender, EventArgs e)
        {
            foreach (var gs in Enum.GetValues(typeof(GrupaSange)))
            {
                comboBoxGrupaSange.Items.Add(gs);
            }
            foreach (var rh in Enum.GetValues(typeof(TipRh)))
            {
                comboBoxRh.Items.Add(rh);
            }
            foreach (PungaSange p in service.GetPungiSangeByDonator(donator))
            {
                comboBoxPunga.Items.Add(p);
            }
        }
    }
}
