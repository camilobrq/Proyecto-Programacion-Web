using Entidad;
using System.Collections.Generic;

namespace Logica
{
    public class PsicologoBuscarResponse
    {
        public Psicologo Psicologo { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public PsicologoBuscarResponse(Psicologo psicologo)
        {
            Psicologo = psicologo;
            IsError = false;
        }
        public PsicologoBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}