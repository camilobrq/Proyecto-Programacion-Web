
using System;
using System.ComponentModel.DataAnnotations;
namespace Entidad
{
    public class Cita
    {
        [Key]
        public int idCita{get; set; }
        public string idPaciente{get; set; }
        public Paciente paciente {get; set; }
        public string tiposSolicitud{get; set; }
        public DateTime fechaDeseada{get; set; }
        
        
    }
}
