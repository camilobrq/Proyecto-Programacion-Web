using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Psicologo: Persona
    {
        [Column(TypeName = "varchar(40)")]
        public string UniversidadEgreso {get; set;}
        public string fechaFinalizacion {get; set;}
        [Column(TypeName = "varchar(40)")]
        public string areaEspecializada {get; set;}
        [Column(TypeName = "varchar(40)")]
        public string areaPsicologo {get; set;}

        public string mesesExperiencia {get; set;}
        [JsonIgnore]
        public Agenda agendaPsicologo { get; set; }
        [JsonIgnore]
        public Usuario usuario { get; set; }

    }
}