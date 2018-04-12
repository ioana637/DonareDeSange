using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CentruDeTransfuzie.utils;
using Service;

namespace GUI
{
    public partial class FormRegisterDonator : Form
    {
        DonatorService service = new DonatorService();
        Judet judet = new Judet();

        public FormRegisterDonator()
        {
            InitializeComponent();
        }

        public void ValidateDonator(string username, string password, string rePassword, string nume, string prenume, string domiciliu, string localitate, string judet, string Email, string telefon)
        {
            string error = "";

            try
            {
                UserDonator donator2 = service.GetUserDonator(username);
                error += " username";
            }
            catch (ValidationException err)
            { }

            if (txtUsername.Text == null || txtUsername.Text == string.Empty)
            {
                error += " username";
            }

            if (domiciliu == string.Empty || domiciliu == null)
            {
                error += " domiciliu";
            }
            if (nume == string.Empty || nume == null)
            {
                error += " nume";
            }
            if (prenume == string.Empty || prenume == null)
            {
                error += " prenume";
            }
            if (password == null || password == string.Empty)
            {
                error += " password";
            }
            if (password != rePassword || rePassword == string.Empty || rePassword == null)
            {
                error += " reconfirm";
            }
            
            if (localitate == string.Empty || localitate == null)
            {
                error += " localitate";
            }

            if (judet == string.Empty || judet == null)
            {
                error += " judet";
            }

            if (Email == string.Empty || Email == null)
            {
                error += " email";
            }

            if (telefon == string.Empty || telefon == null || telefon.Length != 10)
            {
                error += " telefon";
            }

            if (error != "")
            {
                throw new System.ComponentModel.DataAnnotations.ValidationException(error);
            }



        }

        private void FormRegisterDonator_Load(object sender, EventArgs e)
        {
            #region Dropdown Data_Nasterii
            for (int i = 1; i <= 31; i++)
            {
                if (i <= 12)
                {
                    cb_luna.Items.Add(i);
                }
                cb_zi.Items.Add(i);
            }

            for (int i = 2000; i >= 1958; i--)
            {
                cb_an.Items.Add(i);
            }

            #endregion

            #region Judet
            
            foreach(var i in judet.judet.Keys)
            {
                cmbJudet1.Items.Add(i.ToString());
                cmbJudet2.Items.Add(i.ToString());
            }

            #endregion

        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnInregistreaza_Click_1(object sender, EventArgs e)
        {
            #region User Data
            string Nume = txtNume.Text;
            string Prenume = txtPrenume.Text;
            string Username = txtUsername.Text;
            string Password = txtPsw.Text;
            string RePassword = txtREpsw.Text;
            string Zi = cb_zi.Text;
            string Luna = cb_luna.Text;
            string An = cb_an.Text;
            string sex;
            if (rdB_F.Checked == true)
            {
                sex = "F";
            }
            else
            {
                sex = "M";
            }
            string Domiciliu = txtDomiciliu.Text;
            string Localitate1 = cmbLoc1.Text;
            string Judet1 = cmbJudet1.Text;
            string Resedinta = txtResedinta.Text;
            string Localitate2 = cmbLoc1.Text;
            string Judet2 = cmbJudet2.Text;
            string Email = txtEmail.Text;
            string Telefon = txtTelefon.Text;

            #endregion

            try
            {
                #region Validation
                ValidateDonator(Username, Password, RePassword, Nume, Prenume, Domiciliu, Localitate1, Judet1, Email, Telefon);

                DateTime DataNasterii = new DateTime(Int32.Parse(An), Int32.Parse(Luna), Int32.Parse(Zi));

                lblDateInvalide.Visible = false;
                lblDn.Visible = false;
                lblDom.Visible = false;
                lblEmail.Visible = false;
                lblJud.Visible = false;
                lblLoc.Visible = false;
                lblNume.Visible = false;
                lblNume.Visible = false;
                lblPren.Visible = false;
                lblTel.Visible = false;
                #endregion

                service.RegisterDonator(Username, Password, Nume, Prenume, sex, DataNasterii, Domiciliu, Localitate1, Judet1, Resedinta, Localitate2, Judet2, Telefon, Email);
                try
                {
                    service.GetUserDonator(Username);
                    this.Close();
                }
                catch (ValidationException err)
                {
                    MessageBox.Show("User could not be added");
                }
            }
            catch (System.ComponentModel.DataAnnotations.ValidationException error)
            {
                lblDateInvalide.Visible = true;

                #region ValidStars

                if (error.Message.Contains("password"))
                {
                    lblPassw.Visible = true;
                }
                else
                {
                    lblPassw.Visible = false;
                }
                if (error.Message.Contains("reconfirm"))
                {
                    lblREpsw.Visible = true;
                }
                else
                {
                    lblREpsw.Visible = false;
                }
                if (error.Message.Contains("username"))
                {
                    lblUsername.Visible = true;
                }
                else
                {
                    lblUsername.Visible = false;
                }
                if (error.Message.Contains("nume"))
                {
                    lblNume.Visible = true;
                }
                else
                {
                    lblNume.Visible = false;
                }

                if (error.Message.Contains("prenume"))
                {
                    lblPren.Visible = true;
                }
                else
                {
                    lblPren.Visible = false;
                }
                if (error.Message.Contains("localitate"))
                {
                    lblLoc.Visible = true;
                }
                else
                {
                    lblLoc.Visible = false;
                }
                if (error.Message.Contains("domiciliu"))
                {
                    lblDom.Visible = true;
                }
                else
                {
                    lblDom.Visible = false;
                }
               

                if (error.Message.Contains("judet"))
                {
                    lblJud.Visible = true;
                }
                else
                {
                    lblJud.Visible = false;
                }
                if (error.Message.Contains("email"))
                {
                    lblEmail.Visible = true;
                }
                else
                {
                    lblEmail.Visible = false;
                }
                if (error.Message.Contains("telefon"))
                {
                    lblTel.Visible = true;
                }
                else
                {
                    lblTel.Visible = false;
                }
                #endregion
            }
        }

        private void checkRes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRes.Checked == true)
            {
                txtResedinta.Enabled = true;
                cmbJudet2.Enabled = true;
                cmbLoc2.Enabled = true;
            }
            else
            {
                txtResedinta.Enabled = false;
                cmbJudet2.Enabled = false;
                cmbLoc2.Enabled = false;
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbJudet1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLoc1.Items.Clear();

            int index = cmbJudet1.SelectedIndex;
            var key = cmbJudet1.Items[index];

            List<string> vector = new List<string>();
            judet.judet.TryGetValue(key.ToString(), out vector);

            if (judet.judet.ContainsKey(key.ToString()))
            {
                foreach (var i in vector)
                {
                    cmbLoc1.Items.Add(i);
                }
            }

        }

        private void cmbJudet2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLoc2.Items.Clear();

            int index = cmbJudet2.SelectedIndex;
            var key = cmbJudet2.Items[index];

            List<string> vector = new List<string>();
            judet.judet.TryGetValue(key.ToString(), out vector);

            if (judet.judet.ContainsKey(key.ToString()))
            {
                foreach (var i in vector)
                {
                    cmbLoc2.Items.Add(i);
                }
            }
        }
    }


}
