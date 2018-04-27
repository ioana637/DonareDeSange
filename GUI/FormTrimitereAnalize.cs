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
    public partial class FormTrimitereAnalize : Form
    {
        private CentruService service;
        public FormTrimitereAnalize(CentruService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void buttonTrimite_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {

        }
    }
}
