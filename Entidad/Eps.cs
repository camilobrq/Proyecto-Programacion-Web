using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Eps
    {
        [Key]
        public int idEps { get; set; }
        public string Administradora { get; set; }
        
    }
}