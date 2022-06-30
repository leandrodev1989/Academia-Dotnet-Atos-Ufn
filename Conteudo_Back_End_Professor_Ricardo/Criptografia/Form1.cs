using System;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        Assimetrica a;
        Simetrica s;

        public Form1()
        {
            InitializeComponent();
            a = new Assimetrica();
            s = new Simetrica();
        }


        private void btncriptografia_Click(object sender, EventArgs e)
        {
            string frase, frasecript;
            frase = txbfrase.Text;
            frasecript = a.encrypt(frase);
            lblcript.Text = frasecript;
        }


        private void btndescripto_Click(object sender, EventArgs e)
        {
            string frasecript, frase;
            frasecript = lblcript.Text;
            frase = a.decrypt(frasecript);      
            lbldescriptografar.Text = frase;
        }

        private void btncriptosimetrico_Click(object sender, EventArgs e)
        {
            string frasecript, frase, chave;
            chave = txbchave.Text;
            frase = txbfrase.Text;
            frasecript =  s.EncryptData(frase, chave);
            lblcript.Text = frasecript;
        }

        private void btndescriptosimetrico_Click(object sender, EventArgs e)
        {
            string frasecript, frase , chave;
            chave = txbchave.Text;
            frasecript = lblcript.Text;
            frase = s.DecryptData(frasecript, chave);
            lbldescriptografar.Text = frase;
          

        }
    }
}
