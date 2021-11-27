using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Persona: Usuario
    {

        [Column(TypeName = "varchar(30)")] 
        public string identificacion {get; set;}
 
        [Column(TypeName = "varchar(20)")]
        public string tipoDocumento { get; set; }
 
        [Column(TypeName = "varchar(30)")]
        public string nombre {get; set;}

        [Column(TypeName = "varchar(30)")]
        public string apellido {get; set;}

        [Column(TypeName = "varchar(10)")]
        public string sexo {get; set;}
        public DateTime fechaNacimiento { get; set; }
        public string telefono {get; set;}
        [Column(TypeName = "varchar(20)")]
        public string direccion {get; set;}
        [Column(TypeName = "varchar(30)")]
        public string correo {get; set;}

        
    }
}
