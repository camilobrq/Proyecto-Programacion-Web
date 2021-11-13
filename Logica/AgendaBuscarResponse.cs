using Entidad;
using System.Collections.Generic;

namespace Logica
{
    public class AgendaBuscarResponse
    {
        public Agenda Agenda { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public AgendaBuscarResponse(Agenda agenda)
        {
            Agenda = agenda;
            IsError = false;
        }
        public AgendaBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}