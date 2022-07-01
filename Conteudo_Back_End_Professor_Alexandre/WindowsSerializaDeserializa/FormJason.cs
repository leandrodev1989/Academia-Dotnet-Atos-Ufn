using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsSerializaDeserializa
{
    public partial class FormJason : Form
    {
        public FormJason()
        {
            InitializeComponent();
        }

        List<Paciente> listapacientes = new List<Paciente>();

        

        private bool saoValidoscampos()
        {
            return !textBoxnome.Text.Equals("") && !textBoxdatanascimento.Text.Equals("") && textBoxcpf.Text.Equals("");
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(textBoxnome.Text, DateTime.Parse(textBoxdatanascimento.Text), textBoxcpf.Text);

            paciente.Nome = textBoxnome.Text;
            paciente.Datanascimento = DateTime.Parse(textBoxdatanascimento.Text);
            paciente.Cpf = textBoxcpf.Text;

            listapacientes.Add(paciente);

            tblista.AppendText(paciente.Nome + " - " + paciente.Datanascimento.ToShortDateString() + " - " +  paciente.Cpf + Environment.NewLine);
        }

        private void btnserializar_Click(object sender, EventArgs e)
        {
           
            JsonSerializer serializadorJSON = new JsonSerializer();
            serializadorJSON.Formatting = Formatting.Indented;
            StreamWriter procurador = new StreamWriter(@"C:\teste\paciente.json");
            JsonWriter escritorJSON = new JsonTextWriter(procurador);
            serializadorJSON.Serialize(escritorJSON, listapacientes);
            procurador.Close();
            escritorJSON.Close();

            MessageBox.Show("Sucesso para serializar com JSON");
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\teste\paciente.json");
            listapacientes.Clear();

            listapacientes.AddRange(JsonConvert.DeserializeObject<List<Paciente>>(json));
            //codigo para exibir os dados da pessoa deserializada
            

        }

        
    }
}
