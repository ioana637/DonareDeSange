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
        private int idMedicCurent;
        private List<Pacient> listPacienti = new List<Pacient>();
        private BindingSource bindingSourceP;


        public FormMedic(UserMedicService service, int idMedicCurent)
        {
            InitializeComponent();
            this.serviceMedic = service;
            this.idMedicCurent = idMedicCurent;
            //createDataGridView1();
            loadDataGridView1();

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogareMedic formLogareMedic = new FormLogareMedic(serviceMedic);
            this.Hide();
            formLogareMedic.Closed += (s, args) => this.Close();
            formLogareMedic.ShowDialog();
        }

     
        private void button2_Click(object sender, EventArgs e)  //adaugare pacient
        {
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

                #endregion

                serviceMedic.AdaugaPacient(idMedic,Nume, Prenume, Email, esteDonator);
                loadDataGridView1();


            }
            catch (System.ComponentModel.DataAnnotations.ValidationException error)
            {
               
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

        }



    }
}
