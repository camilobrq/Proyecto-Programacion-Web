using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class EvaluacionInputModel
    {
        
    
        public string identificacionPaciente {get; set;}
        public string identificacionPsicologo {get; set;}
        public DateTime fecha { get; set; }
        public string diagnostico {get; set;}

    }

    public class EvaluacionViewModel : EvaluacionInputModel
    {
       
        public EvaluacionViewModel()
        {

        }
        public EvaluacionViewModel(Evaluacion evaluacion)
        {
            IdEvaluacion=evaluacion.IdEvaluacion;
            identificacionPaciente= evaluacion.identificacionPaciente;
           identificacionPsicologo = evaluacion.identificacionPsicologo;
           fecha = evaluacion.fecha;
           diagnostico = evaluacion.diagnostico;
           
        }
          public int IdEvaluacion { get; set; }
    }
}