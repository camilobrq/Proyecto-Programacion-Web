using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EnfermedadConsultaResponse
    {
        public List<Enfermedad> Enfermedades { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public EnfermedadConsultaResponse(List<Enfermedad> enfermedades)
        {
            Enfermedades = enfermedades;
            Error = false;
        }
        public EnfermedadConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}