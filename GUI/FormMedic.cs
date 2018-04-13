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
        public FormMedic(UserMedicService service, int idMedicCurent)
        {
            InitializeComponent();
            this.serviceMedic = service;
            this.idMedicCurent = idMedicCurent;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogareMedic formLogareMedic = new FormLogareMedic(serviceMedic);
            this.Hide();
            formLogareMedic.Closed += (s, args) => this.Close();
            formLogareMedic.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
              

            }
            catch (System.ComponentModel.DataAnnotations.ValidationException error)
            {
               
            }

        }
    }
}
