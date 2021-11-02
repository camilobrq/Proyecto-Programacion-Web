using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class CitaInputModel
    {
        
        public string idPaciente{get; set; }
        public string tiposSolicitud{get; set; }
        public DateTime fechaDeseada{get; set; }

    }

    public class CitaViewModel : CitaInputModel
    {
       
        public CitaViewModel()
        {

        }
        public CitaViewModel(Cita cita)
        {
            idCita= cita.idCita;
           idPaciente = cita.idPaciente;
           tiposSolicitud = cita.tiposSolicitud;
           fechaDeseada = cita.fechaDeseada;
           
        }
        public int idCita{get; set; }
    }
}