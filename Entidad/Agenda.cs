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
        [JsonIgnore]
        public List<Disponibilidad> disponibilidadesPsicologo { get; set;  }

    }
}
