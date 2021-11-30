using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Evaluacion
    {
         [Key]
        public int IdEvaluacion { get; set; }
        public string identificacionPaciente {get; set;}
         [JsonIgnore]
        public Paciente paciente {get; set;}
        public string identificacionPsicologo {get; set;}
        [JsonIgnore]
        public Psicologo Psicologo {get; set;}
        public string diagnostico {get; set;}
        public string ocupacion { get; set; } 
        public string consulta { get; set; }
        public string observacion { get; set; }
        public string prueba { get; set; }
        public string analisis { get; set; }
        public string pronostico { get; set; }
        public string recomendacion { get; set; }
        public List<Cita> citas { get; set; }
    }
}
