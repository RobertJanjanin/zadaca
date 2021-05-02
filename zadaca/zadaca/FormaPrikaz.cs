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
    public partial class FormaPrikaz : Form
    {
        public FormaPrikaz()
        {
            InitializeComponent();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            FormaFiltriraj frm = new FormaFiltriraj();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
