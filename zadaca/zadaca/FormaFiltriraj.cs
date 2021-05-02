using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadaca
{
    public partial class FormaFiltriraj : Form
    {
        public FormaFiltriraj()
        {
            InitializeComponent();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FormaPrikaz frm = new FormaPrikaz();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
