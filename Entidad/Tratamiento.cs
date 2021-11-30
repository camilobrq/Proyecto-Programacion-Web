using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Tratamiento
    {
        [Key]
        public int IdTratamiento { get; set; }
        public string identificacionPaciente {get; set;}
        public Paciente paciente {get; set;}
        public string identificacionPsicologo {get; set;}
        public Psicologo Psicologo {get; set;}
        public DateTime fecha { get; set; }
        
        public string codigo_3 { get; set; }
        public string codigo_4 { get; set; }
        public string descripcion_3 { get; set; }
        public string descripcion_4 { get; set; }
        public string medicacion {get; set;}
        public string tratamientoPaso {get; set;} 
    }
}