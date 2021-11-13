using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgendaConsultaResponse
    {
        public List<Agenda> Agendas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public AgendaConsultaResponse(List<Agenda> agendas)
        {
            Agendas = agendas;
            Error = false;
        }
        public AgendaConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}