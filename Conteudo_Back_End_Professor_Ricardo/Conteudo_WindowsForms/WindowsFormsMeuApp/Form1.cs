using System;
using System.Windows.Forms;

namespace WindowsFormsMeuApp
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void BTok_Click(object sender, EventArgs e)
        {
            

            if (tbNome.Text == null || string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("O Campo Nome  não pode ser vazio ou null!!");
                return;
            }
            else if (tbEmail.Text == null || string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("O Campo Email  não pode ser vazio ou null!!");
                return;
            }
            else if (tbEndereco.Text == null || string.IsNullOrEmpty(tbEndereco.Text))
            {
                MessageBox.Show("O Campo Endereço não pode ser vazio ou null!!");
                return;
            }
            else if (tbBairro.Text == null || string.IsNullOrEmpty(tbBairro.Text))
            {
                MessageBox.Show("O Campo Nome  não pode ser vazio ou null!!");
                return;
            }
            else if (tbCidade.Text == null || string.IsNullOrEmpty(tbCidade.Text))
            {
                MessageBox.Show("O Campo Cidade não pode ser vazio ou null!!");
                return;
            }
            else if (tbTelefone.Text == null || string.IsNullOrEmpty(tbTelefone.Text))
            {
                MessageBox.Show("O Campo Telefone não pode ser vazio ou null!!");
                return;

            }
            else
            {
                MessageBox.Show("Nome: " + tbNome.Text + "\nE-mail: " + tbEmail.Text + "\nEndereço: " 
                + tbEndereco.Text + "\nBairro: " + tbBairro.Text + "\nCidade: " + tbCidade.Text + "\nTelefone: " + tbTelefone.Text);
                MessageBox.Show("Cadastro efetuado!");
            }
            
        }


        private void BTCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voçê clicou Cancelar");
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }
    }
}
