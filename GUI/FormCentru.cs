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
    public partial class FormCentru : Form
    {
        private DonatorService serviceDonator;
        private string judet;
        private List<Donator> listDonatori = new List<Donator>();
        private BindingSource bindingSource;


        public FormCentru(String judet)
        {
            this.judet = judet;
            InitializeComponent();
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

    }
}
