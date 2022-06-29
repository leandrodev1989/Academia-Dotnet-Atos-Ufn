using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasProdutos.Model;

namespace VendasProdutos
{
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();
        }
        private void BTbtnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente( tbxCpf.Text, tbxNome.Text, tbxTelefone.Text, tbxEmail.Text);

           

            if (cliente.gravarCliente())
            {
                MessageBox.Show("Cliente Cadastrado Com Sucesso");        
            }
        }

        
    }
}
