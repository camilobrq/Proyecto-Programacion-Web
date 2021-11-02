using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PsicologoConsultaResponse
    {
        public List<Psicologo> Psicologo { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public PsicologoConsultaResponse(List<Psicologo> psicologo)
        {
            Psicologo = psicologo;
            Error = false;
        }
        public PsicologoConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}