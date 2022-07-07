using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18a_WinFormsApp_Entity_CodeFirst
{
    public  class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Email { get; set; }
        public string NomePaciente { get; set; }


        public Paciente(string email, string nomepaciente)
        {
            Email = Email;
            NomePaciente = nomepaciente;

        }

    }
}
