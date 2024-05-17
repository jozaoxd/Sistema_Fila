using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_extensao
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public Servicio Servicio { get; set; }
        public Paciente(string nome, Servicio servicio)
        {
            Nome = nome;
            Servicio = servicio;
        }
        public Paciente()
        {

        }
        
    }
}
