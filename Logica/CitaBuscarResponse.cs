using Entidad;
using System.Collections.Generic;

namespace Logica
{
    public class CitaBuscarResponse
    {
        public Cita Cita { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public CitaBuscarResponse(Cita cita)
        {
            Cita = cita;
            IsError = false;
        }
        public CitaBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}