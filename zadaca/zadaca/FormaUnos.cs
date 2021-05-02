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
    public partial class FormaUnos : Form
    {
        List<Ucenik> listaUcenika = new List<Ucenik>();
        public FormaUnos()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Pogrešno ste upisali podatke", "Greška");
                return;
            }
            
            Ucenik ucenik = new Ucenik(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
            listaUcenika.Add(ucenik);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = " ";
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            FormaPocetna frm = new FormaPocetna();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }
    }
}
