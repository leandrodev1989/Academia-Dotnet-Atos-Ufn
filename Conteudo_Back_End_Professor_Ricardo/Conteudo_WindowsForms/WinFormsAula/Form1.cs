using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAula
{
    public partial class FLimpar : Form
    {
        public FLimpar()
        {
            InitializeComponent();
        }

        private void textBoxModeloCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbFabricante.Clear();
            tbModeloCarro.Clear();
            // lbllPortas.Clear.Select();
            //lbOpcionais.Items.Clear();
            //lbOpcionais.Items.Add("Asas");

            foreach(int checados in lbOpcionais.CheckedIndices)
            {

                lbOpcionais.SetItemChecked(checados, false);
            }
            cbPortas.ResetText();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
