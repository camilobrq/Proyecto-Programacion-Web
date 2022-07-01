using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Tratamiento
    {
        [Key]
        public int IdTratamiento { get; set; }
        public string identificacionPaciente {get; set;}
        [JsonIgnore]
        public Paciente paciente {get; set;}
        public string identificacionPsicologo {get; set;}
        [JsonIgnore]
        public Psicologo Psicologo {get; set;}
        public DateTime fecha { get; set; }
        public string codigo_3 { get; set; }
        public string codigo_4 { get; set; }
        public string descripcion_3 { get; set; }
        public string descripcion_4 { get; set; }
        public string medicacion {get; set;}
        public string tratamientoPaso {get; set;}
        public List<Cita> Citas { get; set; }
    }
}