using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentruDeTransfuzie1.model;
using Service;

namespace GUI
{
    public partial class CerereForm : Form
    {
        public string message { get; set; }
        public Cerere cerere { get; set; }
        public Stoc stoc { get; set; }
        public CentruTransfuzie centru { get; set; }

        public CerereForm(string message, Cerere cerere, Stoc stoc, CentruTransfuzie centru)
        {
            this.message = message;
            this.cerere = cerere;
            this.stoc = stoc;
            this.centru = centru;
            InitializeComponent();
        }

        private void CerereForm_Load(object sender, EventArgs e)
        {
            lblmesaj.Text = message;
        }

        private void btnTrimiteSange_Click(object sender, EventArgs e)
        {
            CerereService service = new CerereService();

            if (stoc.GlobuleRosii >= cerere.CantitateGlobuleRosii)
            {
                stoc.GlobuleRosii -= cerere.CantitateGlobuleRosii;
            }
            else
            {
                stoc.GlobuleRosii = 0;
            }

            if (stoc.Plasma >= cerere.CantitatePlasma)
            {
                stoc.Plasma -= cerere.CantitatePlasma;
            }
            else
            {
                stoc.Plasma = 0;
            }

            if (stoc.Trombocite >= cerere.CantitateTrombocite)
            {
                stoc.Trombocite -= cerere.CantitateTrombocite;
            }
            else
            {
                stoc.Trombocite = 0;
            }

            if (stoc.TotalSange >= cerere.CantitateSange)
            {
                stoc.TotalSange -= cerere.CantitateSange;
            }
            else
            {
                stoc.TotalSange = 0;
            }

            service.UpdateStoc(this.stoc);

            this.Close();

        }

        private void btnNotifica_Click(object sender, EventArgs e)
        {
            DonatorService donatorService = new DonatorService();
            var smecherie = donatorService.GetAllDonatori();
            CerereService cerereservice = new CerereService();

            List<Donator> lista = new List<Donator>();

            foreach (var i in smecherie)
            {
                if (i.Localitate == centru.Oras && i.Activ == "T")
                {
                    cerereservice.AddNotificare(i.Id, centru.Id);
                    lista.Add(i);
                }
            }
            if (lista.Count <= 10)
            {
                foreach (var i in smecherie)
                {
                    if (i.Judet == centru.Judet && !lista.Contains(i))
                    {
                        cerereservice.AddNotificare(i.Id, centru.Id);
                        lista.Add(i);
                    }
                }
            }
            if(lista.Count <=10)
            {
                foreach (var i in smecherie)
                {
                    if (!lista.Contains(i))
                    {
                        cerereservice.AddNotificare(i.Id, centru.Id);
                        lista.Add(i);
                    }
                }
            }

            this.Close();

        }
    }
}
