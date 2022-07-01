using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsSerializaDeserializa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //carragarlista(pacientes);
        }


        public void carragarlista(List<Paciente> pacientes)
        {
            foreach (Paciente i in pacientes)
            {
                tblista.AppendText(i.Nome + i.Cpf + i.Datanascimento + Environment.NewLine);
            }

        }

        static List<Paciente> pacientes = new List<Paciente>();

        private bool saoValidoscampos()
        {
            return !textBoxnome.Text.Equals("") && !textBoxdatanascimento.Text.Equals("") && textBoxcpf.Text.Equals("");
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (saoValidoscampos())
            {
                try
                {
                    Paciente p = new Paciente(textBoxnome.Text, DateTime.Parse(textBoxdatanascimento.Text), textBoxcpf.Text);

                    if (Paciente.jacadastrado(pacientes, p.Nome))
                    {
                        MessageBox.Show("PACIENTE JÁ CADASTRADO");
                    }
                    else
                    {
                       
                        pacientes.Add(p);
                        MessageBox.Show("PACIENTE CADASTRADO COM SUCESSO");

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Data inválida", "Alerta");
                }            

            }
            else
            {
                MessageBox.Show("Todos os Campos precisam ser preenchidos", "Alerta");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (pacientes.Count > 0)
                {
                    Serializador.serializarXML(pacientes, @"C:\teste\pacientes.xml");
                    tblista.Text = Arquivo.lerArquivo(@"C:\teste\pacientes.xml");
                }
                else
                {
                    MessageBox.Show("Lista de pacientes vazia!", "Alerta");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serializador.deserializarXML(pacientes, @"C:\teste\pacientes.xml");
        }
    }
}
