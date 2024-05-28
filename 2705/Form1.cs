using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2705
{
    public partial class KimKim : Form
    {
        public KimKim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo");
            btnApagar.Enabled = true;
        }

        private void KimKim_Load(object sender, EventArgs e)
        {
            btnApagar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtSalvarExemplo.Text.Length == 0)
            {
                MessageBox.Show("Nada para limpar");
            }
            else { txtSalvarExemplo.Text = "";
                btnApagar.Enabled = false;
            }
        }

        private void arquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }
    }
}
