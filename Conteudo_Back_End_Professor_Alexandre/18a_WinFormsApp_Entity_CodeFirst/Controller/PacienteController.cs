namespace _18a_WinFormsApp_Entity_CodeFirst.Controller
{
    public static class PacienteController
    {
        public static PacienteContext contexto;
        static PacienteController()
        {
            contexto = new PacienteContext();
        }


        public static void Inserir(Paciente paciente)
        {
            
            contexto.Pacientes.Add(paciente);
            contexto.Entry(paciente).State = paciente.IdPaciente > 0 ? Microsoft.EntityFrameworkCore.EntityState.Modified :
                Microsoft.EntityFrameworkCore.EntityState.Added;
            contexto.SaveChanges();

  
        }

        public static void Atualizar(int id, Paciente paciente)
        {
            contexto.Pacientes.Update(paciente);
            contexto.SaveChanges();
        }

        public static Paciente GetPaciente(int id)
        {
            return contexto.Pacientes.Where(p => p.IdPaciente == p.IdPaciente).FirstOrDefault();
        }

        public static List<Paciente> GetPacientes()
        {
            return contexto.Pacientes.ToList();
        }

        

        public static void Delete(int id)
        {
            Paciente paciente = GetPaciente(id);
            contexto.RemoveRange(paciente);
            contexto.SaveChanges();
        }
    }
}
