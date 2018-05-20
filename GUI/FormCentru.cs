using CentruDeTransfuzie.model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Service.CentruService;

namespace GUI
{
    public partial class FormCentru : Form
    {
        private DonatorService serviceDonator = new DonatorService();
        private CentruService serviceCentru = new CentruService();
        private string judet;
        public string username;
        private List<Donator> listDonatori = new List<Donator>();
        private List<Cerere> listCereri = new List<Cerere>();
        private List<Stoc> listStocuri = new List<Stoc>();
        private List<PungaSange> listPungiSange = new List<PungaSange>();
        private BindingSource bindingSource;
        private string centru;

        public FormCentru(DonatorService service, string user )
        {
            serviceDonator = service;
            centru = user;
            this.username = user;
            InitializeComponent();
            LoadDataGridView1();
            loadDataGridView2();
            loadDataGridView3();
            loadStocSange();

        }

       

        public void LoadDataGridView1()
        {
            listDonatori = serviceDonator.GetAllDonatori();

            bindingSource = new BindingSource(listDonatori, null);
            dataGridView1.DataSource = listDonatori;
            if (bindingSource.Position >= 0)
            {
                dataGridView1.Rows[bindingSource.Position].Selected = true;
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Donator donator = (Donator)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            FormModificareDonator form = new FormModificareDonator(donator, this.serviceDonator, this);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selected = comboBox1.SelectedItem.ToString();
            if (selected.Equals("toți donatorii"))
                LoadDataGridView1();

            if (selected.Equals("după nume"))
            {
                String nume = textBox1.Text;
                if (nume.Equals(""))
                    LoadDataGridView1();
                else
                {
                    listDonatori = serviceDonator.GetDonatoriByNume(nume);

                    bindingSource = new BindingSource(listDonatori, null);
                    dataGridView1.DataSource = bindingSource;
                    if (bindingSource.Position >= 0)
                    {
                        dataGridView1.Rows[bindingSource.Position].Selected = true;
                    }
                }
            }

            else if (selected.Equals("după data nașterii"))
            {
                String dataNasterii = textBox1.Text;

                if (dataNasterii.Equals(""))
                    LoadDataGridView1();
                else
                {
                    listDonatori = serviceDonator.GetDonatoriByDataNasterii(dataNasterii);

                    bindingSource = new BindingSource(listDonatori, null);
                    dataGridView1.DataSource = bindingSource;
                    if (bindingSource.Position >= 0)
                    {
                        dataGridView1.Rows[bindingSource.Position].Selected = true;
                    }
                }
            }

            else if (selected.Equals("după județ"))
            {
                String judet = textBox1.Text;

                if (judet.Equals(""))
                    LoadDataGridView1();
                else
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
            else if (selected.Equals("după activitate"))
            {
                String activitate = textBox1.Text;

                if (activitate.Equals(""))
                    LoadDataGridView1();
                else
                {
                    listDonatori = serviceDonator.GetDonatoriByActivitate(activitate);

                    bindingSource = new BindingSource(listDonatori, null);
                    dataGridView1.DataSource = bindingSource;
                    if (bindingSource.Position >= 0)
                    {
                        dataGridView1.Rows[bindingSource.Position].Selected = true;
                    }
                }
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            FormLogareCentru formLogareCentru = new FormLogareCentru(serviceCentru);
            this.Hide();
            formLogareCentru.Closed += (s, args) => this.Close();
            formLogareCentru.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Donator donator = (Donator)dataGridView1.SelectedRows[0].DataBoundItem;
            if (donator == null)
                MessageBox.Show("Selectați un donator!");
            else
            {
                FormTrimitereAnalize form = new FormTrimitereAnalize(this.serviceCentru, donator);
                form.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "";

            Cerere cerere_de_selectat = (Cerere)dataGridView3.SelectedRows[0].DataBoundItem;
            var lista_cereri = serviceCentru.GetAllCereri();
            Cerere cerere = null;
            foreach (var i in lista_cereri)
            {
                if (i.Id == cerere_de_selectat.Id)
                {
                    cerere = i;
                }
            }

            if (cerere != null)
            {

                var stoc = serviceCentru.GetAllStocuri();

                int grupa;

                Stoc stocBun = null;

                foreach (var i in stoc)
                {
                    if (cerere.Grupa == i.Grupa && cerere.RH == i.RH)
                    {
                        stocBun = i;
                        if (cerere.CantitateGlobuleRosii <= i.GlobuleRosii &&
                        cerere.CantitatePlasma <= i.Plasma &&
                        cerere.CantitateTrombocite <= i.Trombocite &&
                        cerere.CantitateSange <= i.TotalSange)
                        {
                            message = "Cantitate suficienta pentru a implini cererea";
                        }
                        else
                        {
                            message = "Insuficient sange. Notificati donatori sau trimiteti cantitatea din stoc.";
                        }
                    }
                }

                if (stocBun != null)
                {

                    CentruService cService = new CentruService();

                    CentruTransfuzie ctr = cService.GetCentruTransfuzieByName(username);

                    CerereForm formCerere = new CerereForm(message, cerere, stocBun, ctr);
                    formCerere.Show();
                }
            }
        }


        /*
        private void createDataGridView2()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn colData = new DataGridViewTextBoxColumn();
            colData.Name = "Data";
            colData.HeaderText = "Data";
            colData.DataPropertyName = "Data";

            DataGridViewTextBoxColumn colTrimisa = new DataGridViewTextBoxColumn();
            colTrimisa.Name = "Trimisa la analize";
            colTrimisa.HeaderText = "Trimisa la analize";
            colTrimisa.DataPropertyName = "Trimisa la analize";

            DataGridViewTextBoxColumn colSosire = new DataGridViewTextBoxColumn();
            colSosire.Name = "Sosita la analize";
            colSosire.HeaderText = "Sosita la analize";
            colSosire.DataPropertyName = "Sosita la analize";

            DataGridViewTextBoxColumn colSpital = new DataGridViewTextBoxColumn();
            colSpital.Name = "Spital";
            colSpital.HeaderText = "Spital";
            colSpital.DataPropertyName = "Spital";

            DataGridViewTextBoxColumn colStoc = new DataGridViewTextBoxColumn();
            colStoc.Name = "Stoc";
            colStoc.HeaderText = "Stoc";
            colStoc.DataPropertyName = "Stoc";


            dataGridView2.Columns.Add(colData);
            dataGridView2.Columns.Add(colTrimisa);
            dataGridView2.Columns.Add(colSosire);
            dataGridView2.Columns.Add(colSpital);
            dataGridView2.Columns.Add(colStoc);

        }
        */


        private void loadDataGridView2()
        {
           List<PungaSangeTraseu> listPungi = serviceCentru.GetAllPungaSangeTraseu();
            bindingSource = new BindingSource(listPungi, null);
            dataGridView2.DataSource = bindingSource;
            if (bindingSource.Position >= 0)
            {
                dataGridView2.Rows[bindingSource.Position].Selected = true;

            }
            dataGridView2.Columns[0].Visible = false;
            //dataGridView2.Columns[2].Visible = false;
            //dataGridView2.Columns[8].Visible = false;
            //dataGridView2.Columns[9].Visible = false;



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (!dataGridView2.CurrentRow.Selected) throw new Exception("Trebuie selectat tot randul");
           
            Console.WriteLine("da");
            //if ((bool)row.Cells[7].Value) throw new Exception("Cererea a fost tratata deja!");
           // comboBoxGrupa.SelectedItem = row.Cells[8].Value.ToString();
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            PungaSange punga = new PungaSange();
            if (textBoxNume.Text == "" || textBoxPrenume.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Completati toate datele despre donator!");

            }
            else
            {
                Donator donator = new Donator();
                donator.Email = textBoxEmail.Text;
                donator.Nume = textBoxNume.Text;
                donator.Prenume = textBoxPrenume.Text;
                punga.CantitateSange = 0.5F;
                punga.CantitatePlasma = 0.275F;
                punga.CantitateGlobuleRosii = 25;//trilioane
                punga.CantitateTrombocite = 150;//miliarde

                serviceCentru.AddPungaSange(punga, donator, centru);
                loadDataGridView2();

            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView2.SelectedCells[0];
            if (cell.ColumnIndex > 7)
            {
                int idPunga = (int)dataGridView2.Rows[cell.RowIndex].Cells[0].Value;
                TraseuPunga traseu = serviceCentru.GetPunga(idPunga).TraseuPunga;
                traseu.TrimiseLaAnalize = (bool)dataGridView2.Rows[cell.RowIndex].Cells[8].Value;
                traseu.SosireAnalize = (bool)dataGridView2.Rows[cell.RowIndex].Cells[9].Value;
                traseu.StocCentru = (bool)dataGridView2.Rows[cell.RowIndex].Cells[10].Value;
                traseu.SpitalPacient = (bool)dataGridView2.Rows[cell.RowIndex].Cells[11].Value;

                serviceCentru.UpdateTraseu(traseu);
                //Console.WriteLine(traseu.PungaSange.Id);
            }
        }
    }
}
