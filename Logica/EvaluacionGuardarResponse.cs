 using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EvaluacionGuardarResponse
    {
        public Evaluacion Evaluacion { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public EvaluacionGuardarResponse(Evaluacion evaluacion)
        {
            Evaluacion=evaluacion;
           
            IsError = false;
        }
        public EvaluacionGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}