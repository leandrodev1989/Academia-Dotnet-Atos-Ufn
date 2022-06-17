using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplesWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        { 

            Pessoa p = new Pessoa(textBoxnome.Text, Convert.ToInt16(textBoxidade.Text),textBoxcpf.Text,textBoxendereco.Text,
                textBoxbairro.Text,textBoxcep.Text,textBoxcidade.Text);

            MessageBox.Show("Nome do Individuou:" + p.nome + "Idade:" + p.Idade + "Cpf:" + p.cpf + "Endereço:" + p.end + "Bairro:" + p.bairro + "Cep:" + p.cep + "Cidade" + p.cidade);

            textBoxnome.Text = "";
            textBoxidade.Text = "";
            textBoxcpf.Text = "";
            textBoxendereco.Text = "";
            textBoxbairro.Text = "";
            textBoxcep.Text = "";
            textBoxcidade.Text = "";

            p.gravarPessoa();
        }
    }
}
