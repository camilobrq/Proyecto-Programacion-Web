using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Evaluacion
    {
        [Key]
        public int IdEvaluacion { get; set; }
        public string identificacionPaciente {get; set;}
        public Paciente paciente {get; set;}
        public string identificacionPsicologo {get; set;}
        public Psicologo Psicologo {get; set;}
        public DateTime fecha { get; set; }
        public string diagnostico {get; set;}
        public string nombrePaciente { get; set; }   
        public string ocupacion { get; set; } 
        public string lugar { get; set; }
        public string nombrePsicologo { get; set; }
        public string consulta { get; set; }
        public string observacion { get; set; }
        public string prueba { get; set; }
        public string analisis { get; set; }
        public string pronostico { get; set; }
        public string recomendacion { get; set; }
    }
}