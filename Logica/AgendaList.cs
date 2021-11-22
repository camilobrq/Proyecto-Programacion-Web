using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgendaList
    {
        public List<string> listaAgendas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public AgendaList(List<string> agendasList)
        {
            listaAgendas = agendasList;
            Error = false;
        }
        public AgendaList(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}