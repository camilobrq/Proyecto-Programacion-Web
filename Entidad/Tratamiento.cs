using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Tratamiento
    {
        [Key]
        public int idTratamiento { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string nombreTratamiento { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string descripcionTratamiento { get; set; }
    }
}