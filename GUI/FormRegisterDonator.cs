using System;
using System.Windows.Forms;
using Service;

namespace GUI
{
    public partial class FormRegisterDonator : Form
    {
        DonatorService service = new DonatorService();

        public FormRegisterDonator()
        {
            InitializeComponent();
        }

        public void ValidateDonator(string username, string password, string rePassword, string nume, string prenume, string greutate, string domiciliu, string localitate, string judet, string Email, string telefon)
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
            try
            {
                float g = float.Parse(greutate);
                if (g < 50)
                {
                    error += " greutate";
                }
            }
            catch (Exception ex)
            {
                error += " greutate";
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

            cmbJudet1.Items.Add("Alba");
            cmbJudet1.Items.Add("Arad");
            cmbJudet1.Items.Add("Argeș");
            cmbJudet1.Items.Add("Bacău");
            cmbJudet1.Items.Add("Bihor");
            cmbJudet1.Items.Add("Bistrița-Năsăud");
            cmbJudet1.Items.Add("Botoșani");
            cmbJudet1.Items.Add("Brașov");
            cmbJudet1.Items.Add("Brăila");
            cmbJudet1.Items.Add("Caraș-Severin");
            cmbJudet1.Items.Add("Călărași");
            cmbJudet1.Items.Add("Cluj");
            cmbJudet1.Items.Add("Constanța");
            cmbJudet1.Items.Add("Covasna");
            cmbJudet1.Items.Add("Dâmbovița");
            cmbJudet1.Items.Add("Dolj");
            cmbJudet1.Items.Add("Galați");
            cmbJudet1.Items.Add("Giurgiu");
            cmbJudet1.Items.Add("Gorj");
            cmbJudet1.Items.Add("Harghita");
            cmbJudet1.Items.Add("Hunedoara");
            cmbJudet1.Items.Add("Ialomița");
            cmbJudet1.Items.Add("Iași");
            cmbJudet1.Items.Add("Ilfov");
            cmbJudet1.Items.Add("Maramureș");
            cmbJudet1.Items.Add("Mehedinți");
            cmbJudet1.Items.Add("Mureș");
            cmbJudet1.Items.Add("Neamț");
            cmbJudet1.Items.Add("Olt");
            cmbJudet1.Items.Add("Prahova");
            cmbJudet1.Items.Add("Satu Mare");
            cmbJudet1.Items.Add("Sălaj");
            cmbJudet1.Items.Add("Sibiu");
            cmbJudet1.Items.Add("Suceava");
            cmbJudet1.Items.Add("Teleorman");
            cmbJudet1.Items.Add("Timiș");
            cmbJudet1.Items.Add("Tulcea");
            cmbJudet1.Items.Add("Vaslui");
            cmbJudet1.Items.Add("Vâlcea");
            cmbJudet1.Items.Add("Vrancea");

            cmbJudet2.Items.Add("Alba");
            cmbJudet2.Items.Add("Arad");
            cmbJudet2.Items.Add("Argeș");
            cmbJudet2.Items.Add("Bacău");
            cmbJudet2.Items.Add("Bihor");
            cmbJudet2.Items.Add("Bistrița-Năsăud");
            cmbJudet2.Items.Add("Botoșani");
            cmbJudet2.Items.Add("Brașov");
            cmbJudet2.Items.Add("Brăila");
            cmbJudet2.Items.Add("Caraș-Severin");
            cmbJudet2.Items.Add("Călărași");
            cmbJudet2.Items.Add("Cluj");
            cmbJudet2.Items.Add("Constanța");
            cmbJudet2.Items.Add("Covasna");
            cmbJudet2.Items.Add("Dâmbovița");
            cmbJudet2.Items.Add("Dolj");
            cmbJudet2.Items.Add("Galați");
            cmbJudet2.Items.Add("Giurgiu");
            cmbJudet2.Items.Add("Gorj");
            cmbJudet2.Items.Add("Harghita");
            cmbJudet2.Items.Add("Hunedoara");
            cmbJudet2.Items.Add("Ialomița");
            cmbJudet2.Items.Add("Iași");
            cmbJudet2.Items.Add("Ilfov");
            cmbJudet2.Items.Add("Maramureș");
            cmbJudet2.Items.Add("Mehedinți");
            cmbJudet2.Items.Add("Mureș");
            cmbJudet2.Items.Add("Neamț");
            cmbJudet2.Items.Add("Olt");
            cmbJudet2.Items.Add("Prahova");
            cmbJudet2.Items.Add("Satu Mare");
            cmbJudet2.Items.Add("Sălaj");
            cmbJudet2.Items.Add("Sibiu");
            cmbJudet2.Items.Add("Suceava");
            cmbJudet2.Items.Add("Teleorman");
            cmbJudet2.Items.Add("Timiș");
            cmbJudet2.Items.Add("Tulcea");
            cmbJudet2.Items.Add("Vaslui");
            cmbJudet2.Items.Add("Vâlcea");
            cmbJudet2.Items.Add("Vrancea");

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
            string Greutate = txtGreutate.Text;
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
            int SubTratament;
            if (chB_Tratament.Checked == true)
            {
                SubTratament = 1;
            }
            else
            {
                SubTratament = 0;
            }
            int interventiiUltimele6Luni;
            if (chB_Interventie.Checked == true)
            {
                interventiiUltimele6Luni = 1;
            }
            else
            {
                interventiiUltimele6Luni = 0;
            }

            #endregion

            try
            {
                #region Validation
                ValidateDonator(Username, Password, RePassword, Nume, Prenume, Greutate, Domiciliu, Localitate1, Judet1, Email, Telefon);

                DateTime DataNasterii = new DateTime(Int32.Parse(An), Int32.Parse(Luna), Int32.Parse(Zi));

                lblDateInvalide.Visible = false;
                lblDn.Visible = false;
                lblDom.Visible = false;
                lblEmail.Visible = false;
                lblJud.Visible = false;
                lblKg.Visible = false;
                lblLoc.Visible = false;
                lblNume.Visible = false;
                lblNume.Visible = false;
                lblPren.Visible = false;
                lblTel.Visible = false;
                #endregion

                #region Add Localitate
                cmbLoc1.Items.Add(Localitate1);
                cmbLoc2.Items.Add(Localitate1);
                #endregion

                float greutate = float.Parse(Greutate);

                service.RegisterDonator(Username, Password, Nume, Prenume, sex, DataNasterii, Domiciliu, Localitate1, Judet1, Resedinta, Localitate2, Judet2, Telefon, Email, greutate, interventiiUltimele6Luni, SubTratament);
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
                if (error.Message.Contains("greutate"))
                {
                    lblKg.Visible = true;
                }
                else
                {
                    lblKg.Visible = false;
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
    }
}
