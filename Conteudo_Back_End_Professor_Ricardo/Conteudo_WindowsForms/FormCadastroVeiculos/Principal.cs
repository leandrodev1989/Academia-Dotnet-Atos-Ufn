using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCadastroVeiculos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAutomovel fauto = new frmAutomovel();
            fauto.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void automovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutomovel fauto = new frmAutomovel();
            fauto.ShowDialog();
        }

    }
}
