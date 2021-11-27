using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Disponibilidad
    {
        [Key]
        public int idDisponibilidad { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public bool estado { get; set; }
    }
}
