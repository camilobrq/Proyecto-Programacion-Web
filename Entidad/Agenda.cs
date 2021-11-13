using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Agenda 
    {
        [Key]        
        public int idAgenda{get; set; }
        public string idPsicologo { get; set; }
        [JsonIgnore]
        public Psicologo psicologo {get; set; }
        public string nombrePsicologo { get; set; }
        public string areaEspecializada { get; set; }
        public string areaPsicologo { get; set; }
        public DateTime fechaDeseada{get; set; }
        public string horaCita { get; set; }
        
    
    }
}
