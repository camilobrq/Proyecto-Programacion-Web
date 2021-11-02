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
        
    }
}