using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_extensao
{
    internal class Servicio
    {
        public enum TipoServicio
        {
            Medico,
            Enfermeiro,
            Dentista,
            Psicologo
        }
        public TipoServicio Tipo {  get; set; }
        public Servicio() 
        {

        }
        public Servicio(TipoServicio tipo)
        {
            Tipo = tipo;
        }
    }
}
