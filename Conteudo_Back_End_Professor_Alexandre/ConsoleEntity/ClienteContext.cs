using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntity
{
    public class ClienteContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Cliente> Clientes { get; set; }

       
    }
}
