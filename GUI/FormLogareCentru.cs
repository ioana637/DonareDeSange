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
    public partial class FormLogareCentru : Form
    {
        private CentruService serviceCentru;
        private DonatorService serviceDonator=new DonatorService();

        public FormLogareCentru(CentruService serviceCentru)
        {
            this.serviceCentru = serviceCentru;
            InitializeComponent();
            List<CentruTransfuzie> centre = serviceCentru.GetAllCentre();
            foreach (CentruTransfuzie c in centre)
            {
                comboBoxNumeCentru.Items.Add(c.Nume);
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username, parola;
            username = comboBoxNumeCentru.GetItemText(comboBoxNumeCentru.SelectedItem);
            parola = textBoxParolaCentru.Text;

            if (username.Equals("") || parola.Equals(""))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, "Trebuie sa completati ambele campuri", "Eroare!", buttons);
            }
            else
            {
                int result = serviceCentru.Login(username, parola);
                if (result >= 0)
                {
                    Form formMainView = new FormCentru(serviceDonator);
                    this.Hide();
                    formMainView.Closed += (s, args) => this.Close();
                    formMainView.ShowDialog();
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, "Parola nu corespunde cu numele centrului!", "Eroare!", buttons);
                }
            }
        }

    }
}
