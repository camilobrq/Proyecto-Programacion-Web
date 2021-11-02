 using Entidad;
using System.Collections.Generic;

namespace Logica
{
    public class EvaluacionBuscarResponse
    {
        public Evaluacion Evaluacion { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public EvaluacionBuscarResponse(Evaluacion evaluacion)
        {
            Evaluacion = evaluacion;
            IsError = false;
        }
        public EvaluacionBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}