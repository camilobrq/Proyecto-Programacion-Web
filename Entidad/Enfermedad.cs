using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Enfermedad
    {
        [Key]
        public int idEnfermedad { get; set; }
        public string Codigo_3 { get; set; }
        public string Descripcion_3 { get; set; }
        public string Codigo_4 { get; set; }
        public string Descripcion_4 { get; set; } 
    }
}