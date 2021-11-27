using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Diagnostico
    {
        [Key]
        public int idDiagnostico { get; set; }
        public List<Tratamiento> tramientosSeguir { get; set; }
        public Psicologo psicologo { get; set; }
        public string Descripcion { get; set; }
    }
}
