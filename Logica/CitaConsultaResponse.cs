using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CitaConsultaResponse
    {
        public List<Cita> Citas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public CitaConsultaResponse(List<Cita> citas)
        {
            Citas = citas;
            Error = false;
        }
        public CitaConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}