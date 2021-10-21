using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Paciente: Persona
    {
        public string Eps {get; set;}
      
        public List<Cita> citas { get; set; }
    }
}