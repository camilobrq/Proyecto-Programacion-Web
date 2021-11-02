 using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TratamientoConsultaResponse
    {
        public List<Tratamiento> Tratamientos { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public TratamientoConsultaResponse(List<Tratamiento> tratamientos)
        {
            Tratamientos = tratamientos;
            Error = false;
        }
        public TratamientoConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}