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
        private DonatorService serviceDonator = new DonatorService();
        private List<Donator> listDonatori = new List<Donator>();
        private BindingSource bindingSource;


        public FormCentru()
        {
            InitializeComponent();
            loadDataGridView1();
            
        }

        private void loadDataGridView1()
        {
            listDonatori = serviceDonator.GetAllDonatori();

            bindingSource = new BindingSource(listDonatori, null);
            dataGridView1.DataSource = bindingSource;
            if (bindingSource.Position >= 0)
            {
                dataGridView1.Rows[bindingSource.Position].Selected = true;
            }
        }
    }
}
