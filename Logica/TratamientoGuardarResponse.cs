 using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TratamientoGuardarResponse
    {
        public Tratamiento Tratamiento { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public TratamientoGuardarResponse(Tratamiento tratamiento)
        {
            Tratamiento=tratamiento;
           
            IsError = false;
        }
        public TratamientoGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}