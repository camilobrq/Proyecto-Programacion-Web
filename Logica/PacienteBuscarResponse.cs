using Entidad;
using System.Collections.Generic;

namespace Logica
{
    public class PacienteBuscarResponse
    {
        public Paciente Paciente { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public PacienteBuscarResponse(Paciente paciente)
        {
            Paciente = paciente;
            IsError = false;
        }
        public PacienteBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}