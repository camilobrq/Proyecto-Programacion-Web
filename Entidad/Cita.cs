
using System;

namespace Entidad
{
    public class Cita
    {
        public int idCita{get; set; }
        public string idPaciente{get; set; }
        public Paciente paciente {get; set; }
        public string tiposSolicitud{get; set; }
        public DateTime fecha{get; set; }
        public string numeroAutorizacion{get; set; }
        public DateTime fechaVencimientoAutorizacion{get; set; }
       
    }
}
