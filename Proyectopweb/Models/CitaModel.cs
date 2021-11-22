using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class CitaInputModel
    {
        
        public string idPaciente{get; set; }
        public string tiposSolicitud{get; set; }
        public DateTime fechaDeseada{get; set; }
        public string nombre { get; set; }
        public string horaCita { get; set; }
        public string nombrePaciente { get; set; }
        public string estado { get; set; }
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
           nombre=cita.nombre;
           horaCita=cita.horaCita;
           nombrePaciente=cita.nombrePaciente;
           estado=cita.estado;
        }
        public int idCita{get; set; }
    }
}