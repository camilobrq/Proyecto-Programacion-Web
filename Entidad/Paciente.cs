using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
 
namespace Entidad
{
    public class Paciente: Persona
    {
       
        public string Eps {get; set;}
        [JsonIgnore]
        public List<Cita> citas { get; set; }
        [JsonIgnore]
        public Usuario usuario { get; set; }
    }
}