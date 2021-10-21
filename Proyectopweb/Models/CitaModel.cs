using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class CitaInputModel
    {
        public int idCita{get; set; }
        public string idPaciente{get; set; }
        public Paciente paciente {get; set; }
        public string tiposSolicitud{get; set; }
        public DateTime fechaDeseada{get; set; }
        public string numeroAutorizacion{get; set; }
        public DateTime fechaVencimientoAutorizacion{get; set; }
        
    }

    public class CitaViewModel : CitaInputModel
    {
        public CitaViewModel()
        {

        }
        public CitaViewModel(Cita cita)
        {
           idCita = cita.idCita;
           idPaciente = cita.idPaciente;
           paciente = cita.paciente;
           tiposSolicitud = cita.tiposSolicitud;
           fechaDeseada = cita.fechaDeseada;
           numeroAutorizacion =cita.numeroAutorizacion;
           fechaVencimientoAutorizacion =cita.fechaVencimientoAutorizacion;
      
           
        }
        
    }
}