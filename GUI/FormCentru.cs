using CentruDeTransfuzie1.model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCentru : Form
    {
        private DonatorService serviceDonator=new DonatorService();
        private CentruService serviceCentru=new CentruService();
        private string judet;
        private List<Donator> listDonatori = new List<Donator>();
        private List<Cerere> listCereri = new List<Cerere>();
        private List<Stoc> listStocuri = new List<Stoc>();
        private BindingSource bindingSource;

        public FormCentru()
        {
            InitializeComponent();
            loadDataGridView3();
            loadStocSange();
        }

        private void loadDataGridView1()
        {
            listDonatori = serviceDonator.GetDonatoriByJudet(judet);
            bindingSource = new BindingSource(listDonatori, null);
            dataGridView1.DataSource = bindingSource;
            if (bindingSource.Position >= 0)
            {
                dataGridView1.Rows[bindingSource.Position].Selected = true;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormLogareCentru formLogareCentru = new FormLogareCentru(serviceCentru);
            this.Hide();
            formLogareCentru.Closed += (s, args) => this.Close();
            formLogareCentru.ShowDialog();
        }

        private void loadDataGridView3()
        {
            listCereri = serviceCentru.GetAllCereri();
            dataGridView3.DataSource = listCereri;
          
        }

        private void loadStocSange()
        {
            listStocuri = serviceCentru.GetAllStocuri();
            dataGridViewStocSange.DataSource = listStocuri;
        }

    }
}
