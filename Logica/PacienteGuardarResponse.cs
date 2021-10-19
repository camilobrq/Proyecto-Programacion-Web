using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PacienteGuardarResponse
    {
        public Paciente Paciente { get; set; }
        public string Mensaje { get; set; }
      
        public bool IsError { get; set; }

        public PacienteGuardarResponse(Paciente paciente)
        {
            Paciente = paciente;
            IsError = false;
        }
        public PacienteGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}