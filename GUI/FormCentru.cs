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
        private BindingSource bindingSource, bindingSource2;
        private string centru;

        public FormCentru(DonatorService service, string user)
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
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listCereri = serviceCentru.GetAllCereri();
            dataGridView3.DataSource = listCereri;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].Visible = false;
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

            if (cerere != null && cerere.Efectuata != true)
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
                            message = "Cantitatea este suficienta pentru a implini cererea";
                        }
                        else
                        {
                            message = "Ne pare rau dar nu este suficient sange pentru cererea dumneavoastra. \n Notificati donatori sau trimiteti cantitatea de sange din stoc.";
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
            else
            {
                MessageBox.Show("Cererea a fost deja completata.");
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
            dataGridView2.Columns[7].ReadOnly = true;
            int i = 0;
            foreach (PungaSangeTraseu p in listPungi)
            {
                if (p.SosireAnalize)
                    dataGridView2.Rows[i].Cells[8].ReadOnly = true;
                if (p.TrimiseLaAnalize)
                    dataGridView2.Rows[i].Cells[9].ReadOnly = true;
                if (p.StocCentru)
                    dataGridView2.Rows[i].Cells[10].ReadOnly = true;
                if (p.SpitalPacient)
                    dataGridView2.Rows[i].Cells[11].ReadOnly = true;

                i++;

            }


            //dataGridView2.Columns[2].Visible = false;
            //dataGridView2.Columns[8].Visible = false;
            //dataGridView2.Columns[9].Visible = false;



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
                try
                {
                    serviceCentru.AddPungaSange(punga, donator, centru);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadDataGridView2();

            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView2.SelectedCells[0];
            if (cell.ColumnIndex > 7)
            {
                bool ok = true;
                for (int i = 7; i < cell.ColumnIndex; i++)
                    if (!(bool)dataGridView2.Rows[cell.RowIndex].Cells[i].Value)
                        ok = false;
                if (ok)
                {

                    if (cell.ColumnIndex == 10 && !(bool)dataGridView2.Rows[cell.RowIndex].Cells[10].Value)
                    {
                        PungaSangeTraseu pungaSange = (PungaSangeTraseu)dataGridView2.Rows[cell.RowIndex].DataBoundItem;
                        {
                            try
                            {

                                if (serviceCentru.ValidateSange(pungaSange))
                                {
                                    serviceCentru.UpdateStoc(pungaSange);
                                    loadStocSange();
                                    dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = true;
                                    updateTraseu();
                                    dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].ReadOnly = true;
                                    MessageBox.Show("Stocul de sange a fost updatat!");
                                }
                                else
                                {
                                    dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = false;
                                    MessageBox.Show("Analizele pungii de sange nu permit adaugarea acesteia in stocul centrului");
                                }

                            }
                            catch (ValidationException err)
                            {
                                loadStocSange();
                                dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = true;
                                updateTraseu();
                                dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].ReadOnly = true;
                                MessageBox.Show(err.GetMessage() + "Vor fi pastrate doar componentele valabile!");
                            }
                            catch (Exception)
                            {
                                dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = false;
                                MessageBox.Show("Nu exista analize pentru punga de sange selectata! Mai intai trebuie sa completati analizele!");
                            }
                        }


                    }
                    else if (cell.ColumnIndex != 10)
                    {
                        dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = true;
                        updateTraseu();
                        dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].ReadOnly = true;
                    }
                    else
                    {
                        dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = true;
                        dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].ReadOnly = true;
                    }

                }
                else
                {
                    dataGridView2.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = false;
                    MessageBox.Show("Nu puteti selecta decat operatiuni consecutive!");
                }
            }

            // if (!dataGridView2.CurrentRow.Selected) throw new Exception("Trebuie selectat tot randul");
            Console.WriteLine("da");
            //if ((bool)row.Cells[7].Value) throw new Exception("Cererea a fost tratata deja!");
            // comboBoxGrupa.SelectedItem = row.Cells[8].Value.ToString();
        }



        private void updateTraseu()
        {
            DataGridViewCell cell = dataGridView2.SelectedCells[0];
            int idPunga = (int)dataGridView2.Rows[cell.RowIndex].Cells[0].Value;
            TraseuPunga traseu = serviceCentru.GetPunga(idPunga).TraseuPunga;
            traseu.TrimiseLaAnalize = (bool)dataGridView2.Rows[cell.RowIndex].Cells[8].Value;
            traseu.SosireAnalize = (bool)dataGridView2.Rows[cell.RowIndex].Cells[9].Value;
            traseu.StocCentru = (bool)dataGridView2.Rows[cell.RowIndex].Cells[10].Value;
            traseu.SpitalPacient = (bool)dataGridView2.Rows[cell.RowIndex].Cells[11].Value;
            serviceCentru.UpdateTraseu(traseu);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                serviceCentru.EliminareSangeStoc();
            }
            catch (ValidationException err)
            {
                loadStocSange();
                MessageBox.Show(err.GetMessage());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
