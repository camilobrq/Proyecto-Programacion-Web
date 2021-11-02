using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PsicologoGuardarResponse
    {
        public Psicologo Psicologo { get; set; }
        public string Mensaje { get; set; }
      
        public bool IsError { get; set; }

        public PsicologoGuardarResponse(Psicologo psicologo)
        {
            Psicologo = psicologo;
            IsError = false;
        }
        public PsicologoGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}