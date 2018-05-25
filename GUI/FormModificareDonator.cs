using CentruDeTransfuzie.model;
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
    public partial class FormModificareDonator : Form
    {
        Donator donator;
        FormCentru parinte;
        DonatorService service;
        public FormModificareDonator(Donator donator,DonatorService service,FormCentru parinte)
        {
            this.parinte=parinte;
            this.service = service;
            this.donator = donator;
            InitializeComponent();
            textBoxGreutate.Text = donator.Greutate.ToString();
            textBoxPuls.Text = donator.Puls.ToString();
            textBoxTensSist.Text = donator.TensiuneSistolica.ToString();
            textBoxTensDiast.Text = donator.TensiuneDiastolica.ToString();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try {
                ValidateDate();
                donator.Greutate = float.Parse(textBoxGreutate.Text);
                donator.Puls = int.Parse(textBoxPuls.Text);
                donator.TensiuneSistolica = int.Parse(textBoxTensSist.Text);
                donator.TensiuneDiastolica = int.Parse(textBoxTensDiast.Text);
                service.UpdateDonator(donator);
                textBoxGreutate.Clear();
                textBoxPuls.Clear();
                textBoxTensSist.Clear();
                textBoxTensDiast.Clear();
                parinte.LoadDataGridView1();
                this.Close();


            }
            catch (System.ComponentModel.DataAnnotations.ValidationException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ValidateDate()
        {
            string error = "";
            if (textBoxGreutate.Text == null || textBoxGreutate.Text == string.Empty || int.Parse(textBoxGreutate.Text) <= 0)
                error += "Greutate invalidă!\n";
            if (textBoxPuls.Text == null || textBoxPuls.Text == string.Empty || int.Parse(textBoxPuls.Text) <= 0)
                error += "Puls invalid!\n";
            if (textBoxTensSist.Text == null || textBoxTensSist.Text == string.Empty || int.Parse(textBoxTensSist.Text) <= 0)
                error += "Tensiune sistolică invalidă!\n";
            if (textBoxTensSist.Text == null || textBoxTensSist.Text == string.Empty || int.Parse(textBoxTensSist.Text) <= 0)
                error += "Tensiune diastolică invalidă!\n";
            if (error != "")
            {
                throw new System.ComponentModel.DataAnnotations.ValidationException(error);
            }
        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
