using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PacienteConsultaResponse
    {
        public List<Paciente> Pacientes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public PacienteConsultaResponse(List<Paciente> pacientes)
        {
            Pacientes = pacientes;
            Error = false;
        }
        public PacienteConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}