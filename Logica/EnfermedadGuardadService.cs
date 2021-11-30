using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EnfermedadGuardarResponse
    {
        public Enfermedad Enfermedad { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public EnfermedadGuardarResponse(Enfermedad enfermedad)
        {
            Enfermedad=enfermedad;
           
            IsError = false;
        }
        public EnfermedadGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}