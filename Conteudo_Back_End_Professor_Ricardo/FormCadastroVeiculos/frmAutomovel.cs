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
    public partial class frmAutomovel : System.Windows.Forms.Form
    {
        static List<Carro> carros = new List<Carro>();
        public frmAutomovel()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Metodo para limpar os campos e opções caso o usuario queira realizar outro cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbfabricante.Clear();
            tbmodelocarro.Clear();
           
            foreach (int checados in lbOpcionais.CheckedIndices)
            {
                lbOpcionais.SetItemChecked(checados, false);
            }

            cbportas.ResetText();
            dgAutomovel.Rows.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool ac = false, dh = false, abs = false, ve = false, ab = false;
            int portas;
            foreach (string opc in lbOpcionais.CheckedItems)
            {
                if (opc == "Ar condicionado")
                {
                    ac = true;
                }
                if (opc == "Direção hidráulica")
                {
                    dh = true;
                }
                if (opc == "Freios ABS")
                {
                    abs = true;
                }
                if (opc == "Vidros elétricos")
                {
                    ve = true;
                }
                if (opc == "Air bag")
                {
                    ab = true;
                }
            }
            portas = 0;
            if (cbportas.Text == "2 portas") portas = 2;
            else if (cbportas.Text == "3 portas") portas = 3;
            else if (cbportas.Text == "4 portas") portas = 4;
            else if (cbportas.Text == "5 portas") portas = 5;
            Carro c = new Carro(tbmodelocarro.Text, tbfabricante.Text, ac, dh, abs, ab, ve, portas);
            carros.Add(c);
            c.MostrarDadosCarro();
            mostraListadeCarros();

           dgAutomovel.Rows.Add(tbmodelocarro.Text, tbfabricante.Text, ac, dh, abs, ab, ve, portas);




            tbfabricante.Clear();
            tbmodelocarro.Clear();

            foreach (int checados in lbOpcionais.CheckedIndices)
            {
                lbOpcionais.SetItemChecked(checados, false);
            }

            cbportas.ResetText();
        }

        /// <summary>
        /// Metodo Para Mostrar informações da lista
        /// </summary>
        static void mostraListadeCarros()
        {
            foreach (Carro c in carros)
            {
                MessageBox.Show("Carro " + c.modelo + "\nFabricante " + c.fabricante + "\nDH " + c.dh + "\nAr " + c.ar + "\nABS " + c.abs + "\nAir bag " + c.airbag + "\nVidros eletrico " + c.ve + "\nPortas " + c.portas);
            }
        }

        private void btncarregarlista_Click(object sender, EventArgs e)
        {
            dgAutomovel.Rows.Clear();
            foreach (Carro c in carros)
            {
                dgAutomovel.Rows.Add(c.modelo, c.fabricante, c.ar, c.dh, c.abs, c.ve, c.airbag, c.portas);
            }
        }
    }
}
