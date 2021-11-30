
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Cita
    {
        [Key]
        public int idCita{get; set; } 
        public string idPaciente{get; set; }
        [JsonIgnore]
        public Paciente paciente {get; set; }
        [JsonIgnore]
        public List<Agenda> agenda {get; set;}
        public string tiposSolicitud{get; set; }
        public DateTime fechaDeseada{get; set; }
        public string nombre { get; set; }
        public string horaCita{get; set;}
        public string nombrePaciente { get; set; }
        public string estado { get; set; }
        public Evaluacion evaluacion { get; set; }
        public Tratamiento tratamiento { get; set; }
        
    }
}
