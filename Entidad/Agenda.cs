using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Agenda 
    {
        [Key]        
        public int idAgenda{get; set; }
        public string idPsicologo { get; set; }
        [JsonIgnore]
        public Psicologo psicologo {get; set; }
        public int idCita { get; set; }
        [JsonIgnore]
        public Cita cita {get; set; }
        public DateTime fechaDeseada{get; set; }
        public string horaCita { get; set; }

    }
}
