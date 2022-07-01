using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Psicologo: Persona
    {
       
        public string UniversidadEgreso {get; set;}

        public string fechaFinalizacion {get; set;}
       
        public string areaEspecializada {get; set;}

        public string mesesExperiencia {get; set;}

        public List<Evaluacion> evaluaciones { get; set; }

        public List<Agenda> agendas { get; set; }
        [JsonIgnore]
         public Usuario usuario { get; set; }
         

    }
}