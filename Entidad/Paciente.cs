using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Paciente: Persona
    {
        [Column(TypeName = "varchar(40)")]
        public string Eps {get; set;}
        [JsonIgnore]
        public List<Cita> citas { get; set; }

        public Paciente()
        {
            this.tipoUsuario = "Paciente";
        }
    }
}