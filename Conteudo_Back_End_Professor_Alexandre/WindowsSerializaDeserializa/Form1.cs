using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsSerializaDeserializa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            carragarlista(pacientes);
        }


        public void carragarlista(List<Paciente> pacientes)
        {
            foreach (Paciente i in pacientes)
            {
                tblista.AppendText(i.Nome + i.Cpf + i.Datanascimento + Environment.NewLine);
            }

        }

        List<Paciente> pacientes = new List<Paciente>();

        private bool saoValidoscampos()
        {
            return !textBoxnome.Text.Equals("") && !textBoxdatanascimento.Text.Equals("") && textBoxcpf.Text.Equals("");
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (saoValidoscampos())
            {
                Paciente p = new Paciente(textBoxnome.Text.ToUpper(), DateTime.Parse(textBoxdatanascimento.Text), textBoxcpf.Text);

                if (Paciente.jacadastrado(p.nome, pacientes))
                {
                    MessageBox.Show("PACIENTE JÁ CADSTRADO");
                }
                else
                {
                    pacientes.Add(p);


                }


                MessageBox.Show("PACIENTE CADASTRADO COM SUCESSO");

            }
        }
    }
}
