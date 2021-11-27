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
        public string nombreUsuario { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string contraseña { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string tipoUsuario { get; set; }
    }
}
