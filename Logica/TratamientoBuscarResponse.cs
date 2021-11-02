 using Entidad;
using System.Collections.Generic;

namespace Logica
{
    public class TratamientoBuscarResponse
    {
        public Tratamiento Tratamiento { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public TratamientoBuscarResponse(Tratamiento tratamiento)
        {
            Tratamiento = tratamiento;
            IsError = false;
        }
        public TratamientoBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}