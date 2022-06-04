using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculadora
{
    public partial class ljCalculadora : Form
    {
        public ljCalculadora()
        {
            InitializeComponent();
        }

        private void btsomar_Click(object sender, EventArgs e)
        {
            
                
          
                lblResultado.Text = (float.Parse(tbNr1.Text) + float.Parse(tbNr2.Text)).ToString();
                tbNr1.Clear();
                tbNr2.Clear();
                              
        }

        private void btsubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(tbNr1.Text) - float.Parse(tbNr2.Text)).ToString();
            tbNr1.Clear();
            tbNr2.Clear();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(tbNr1.Text) * float.Parse(tbNr2.Text)).ToString();
            tbNr1.Clear();
            tbNr2.Clear();
        }

        private void btdividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(tbNr1.Text) / float.Parse(tbNr2.Text)).ToString();
            tbNr1.Clear();
            tbNr2.Clear();
        }
    }
}

