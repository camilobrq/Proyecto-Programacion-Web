using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }

        public string contrasena { get; set; }
      
        public string tipoUsuario { get; set; }
        
        public string estado { get; set; }
        public string correo {get; set;}
         public string telefono {get; set;}
         public List<Paciente> pacientes { get; set; }
        public List<Psicologo> psicologos { get; set; }
    } 
}
