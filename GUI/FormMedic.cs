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
            //createDataGridView2();
            loadDataGridView2();

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


    }
}
