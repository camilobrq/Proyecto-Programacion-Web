using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class EvaluacionInputModel
    {
        public string identificacionPaciente {get; set;}
        public string identificacionPsicologo {get; set;}
        public string diagnostico {get; set;}
        public string ocupacion { get; set; } 
        public string consulta { get; set; }
        public string observacion { get; set; }
        public string prueba { get; set; }
        public string analisis { get; set; }
        public string pronostico { get; set; }
        public string recomendacion { get; set; }

    }

    public class EvaluacionViewModel : EvaluacionInputModel
    {

        public EvaluacionViewModel()
        {

        }
        public EvaluacionViewModel(Evaluacion evaluacion)
        {
            IdEvaluacion = evaluacion.IdEvaluacion;
            identificacionPaciente = evaluacion.identificacionPaciente;
            identificacionPsicologo = evaluacion.identificacionPsicologo;
            diagnostico = evaluacion.diagnostico;
            ocupacion = evaluacion.ocupacion;
            consulta = evaluacion.consulta;
            observacion = evaluacion.observacion;
            prueba = evaluacion.prueba;
            analisis = evaluacion.analisis;
            pronostico = evaluacion.pronostico;
            recomendacion = evaluacion.recomendacion;
        }
        public int IdEvaluacion { get; set; }
    }
}