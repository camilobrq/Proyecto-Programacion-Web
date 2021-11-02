using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CitaGuardarResponse
    {
        public Cita Cita { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public CitaGuardarResponse(Cita cita)
        {
            Cita=cita;
           
            IsError = false;
        }
        public CitaGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}