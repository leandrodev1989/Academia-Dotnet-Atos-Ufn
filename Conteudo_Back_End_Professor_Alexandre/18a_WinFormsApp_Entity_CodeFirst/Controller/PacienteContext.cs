using Microsoft.EntityFrameworkCore;

namespace _18a_WinFormsApp_Entity_CodeFirst
{
    public class PacienteContext : DbContext
    {
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AC\SQLEXPRESS;Initial Catalog=ATOSUFN;Integrated Security=True");
        }

       public  DbSet<Paciente>? Pacientes { get; set; }
        
    }
}
