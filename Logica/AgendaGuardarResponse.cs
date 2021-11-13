using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgendaGuardarResponse
    {
        public Agenda Agenda { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public AgendaGuardarResponse(Agenda agenda)
        {
            Agenda=agenda;
           
            IsError = false;
        }
        public AgendaGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}