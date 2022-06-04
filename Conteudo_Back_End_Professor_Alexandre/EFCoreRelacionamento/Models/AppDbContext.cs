using Microsoft.EntityFrameworkCore;

namespace EFCoreRelacionamento.Models
{
    public   class AppDbContext : DbContext
    {
        

       public DbSet<Autor> Autores { get; set; }
       public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AC\\SQLSERVER;Initial Catalog=model;Integrated Security=True");
        }
    }
}
