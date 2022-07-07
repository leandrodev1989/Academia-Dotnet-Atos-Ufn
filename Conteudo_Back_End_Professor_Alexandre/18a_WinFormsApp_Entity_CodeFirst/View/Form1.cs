using _18a_WinFormsApp_Entity_CodeFirst.Controller;

namespace _18a_WinFormsApp_Entity_CodeFirst
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        PacienteContext _contexto = new PacienteContext();
        private void limparCampos()
        {
            textBox_nomePaciente.Text = String.Empty;
            textBox_email.Text = String.Empty;
        }


        public bool ValidaAcao()
        {
            if (string.IsNullOrWhiteSpace(textBox_nomePaciente.Text))
                return false;
            else
                return true;
        }
        //


        private void carregarListView()
        {
            try
            {
                //listar contexto

                dataGridViewPaciente.DataSource = PacienteController.GetPacientes();
                //repeticao na lista de pacientes do contexto
                //while ()
                //{
                //    listView_pacientes.Items.Add(leitor["idPaciente"].ToString());
                //    listView_pacientes.Items[i].SubItems.Add(leitor["nome"].ToString());
                //    listView_pacientes.Items[i].SubItems.Add(leitor["email"].ToString());
                //    i++;
                //}               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de Conex�o com o Banco " + ex.Message, "Alerta");
            }
        }

       
    
       

        private void button_salvar_Click_1(object sender, EventArgs e)
        {
            dataGridViewPaciente.DataSource = PacienteController.GetPacientes();
            if (textBox_nomePaciente.Text == String.Empty || textBox_email.Text == String.Empty)
            {
                MessageBox.Show("Campos n�o pode ser vazios");
            }
            else
            {
                Paciente paciente = new Paciente { NomePaciente = textBox_nomePaciente.Text, Email = textBox_email.Text };
                _contexto.Pacientes.Add(paciente);
                 _contexto.SaveChanges();
                
            }
            
            //capturar valores das vari�veis

            this.limparCampos();
            panel_campos.Enabled = false;
        }

        private void button_cadastrar_Click_1(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;

        }

        private void button_deletar_Click_1(object sender, EventArgs e)
        {
            dataGridViewPaciente.DataSource = PacienteController.GetPacientes();
            panel_campos.Enabled = true;
            try
            {
                Paciente paciente = _contexto.Pacientes.FirstOrDefault(x => x.NomePaciente == textBox_nomePaciente.Text);
                _contexto.Pacientes.Remove(paciente);
                _contexto.SaveChanges();

                MessageBox.Show("Paciente Excluido Com Sucesso");

            }
            catch (Exception erro)
            {
               
            }
        
                //pesquisar no contexto

                this.limparCampos();
                //recarregar ListView
                this.carregarListView();
                      
            
        }

        private void button_editar_Click_1(object sender, EventArgs e)
        {
            dataGridViewPaciente.DataSource = PacienteController.GetPacientes();
            panel_campos.Enabled = true;
            try
            {
               
                Paciente paciente = _contexto.Pacientes.First(x => x.IdPaciente == x.IdPaciente);

                paciente.NomePaciente = textBox_nomePaciente.Text;
                paciente.Email = textBox_email.Text;
                _contexto.Pacientes.Update(paciente);
                _contexto.SaveChanges();

                MessageBox.Show("Paciente Atualizado Com Sucesso");

            }
            catch (Exception erro)
            {

            }

            this.limparCampos();
            //recarregar ListView
            this.carregarListView();
           
        }

        private void button_pesquisar_Click_1(object sender, EventArgs e)
        {
            dataGridViewPaciente.DataSource = PacienteController.GetPacientes();
        }
    }
}