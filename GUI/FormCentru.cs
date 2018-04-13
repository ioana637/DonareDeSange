﻿using CentruDeTransfuzie1.model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCentru : Form
    {
        private DonatorService serviceDonator=new DonatorService();
        private CentruService serviceCentru=new CentruService();
        private string judet;
        private List<Donator> listDonatori = new List<Donator>();
        private List<Cerere> listCereri = new List<Cerere>();
        private List<Stoc> listStocuri = new List<Stoc>();
        private BindingSource bindingSource;

        public FormCentru(DonatorService service)
        {
            serviceDonator = service;
            InitializeComponent();
            LoadDataGridView1();
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
            Donator donator=(Donator)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            FormModificareDonator form = new FormModificareDonator(donator,this.serviceDonator,this);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selected = comboBox1.SelectedItem.ToString();
            if (selected.Equals("toti donatorii"))
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

            else if (selected.Equals("după data nastere"))
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

            else if (selected.Equals("după judet"))
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
    }
}
