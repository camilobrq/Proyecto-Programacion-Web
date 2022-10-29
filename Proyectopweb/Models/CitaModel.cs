using System;
using System.ComponentModel.DataAnnotations;
using Entidad;

namespace Proyectopweb.Models
{
    public class CitaInputModel
    {
        [Required(ErrorMessage = "la identifiacion del paciente es requerida")]
        [StringLength(10, ErrorMessage ="la identificacion debe tener de 7-10 digitos", MinimumLength =7)]
        public string idPaciente{get; set; }
        [Required(ErrorMessage = "la fecha de la cita es requerida")]
        public DateTime fechaDeseada{get; set; }

        [Required(ErrorMessage = "la el nombre del psicologo es requerido")]
        [StringLength(20, ErrorMessage = "el nombre del psicologo debe tener de 3-20 digitos", MinimumLength = 3)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "la hora de la cita es requerida")]
        public string horaCita { get; set; }
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
           fechaDeseada = cita.fechaDeseada;
           nombre=cita.nombre;
           horaCita=cita.horaCita;
           estado=cita.estado;
        }
        public int idCita{get; set; }
    }
}