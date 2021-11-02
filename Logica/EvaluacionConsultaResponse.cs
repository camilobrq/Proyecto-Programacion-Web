 using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EvaluacionConsultaResponse
    {
        public List<Evaluacion> Evaluaciones { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public EvaluacionConsultaResponse(List<Evaluacion> evaluaciones)
        {
            Evaluaciones = evaluaciones;
            Error = false;
        }
        public EvaluacionConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}