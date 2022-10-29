using System;
using Entidad;
using System.ComponentModel.DataAnnotations;
namespace Proyectopweb.Models
{
    public class AgendaInputModel
    {
        [Required(ErrorMessage ="debe digitar el id del psicologo")]
        [StringLength(10, ErrorMessage = "la identificacion debe tener de 7-10 digitos", MinimumLength = 7)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string idPsicologo { get; set; }
        public DateTime fechaDeseada { get; set; }
        [Required(ErrorMessage = "debe seleccionar una hora")]
        public string horaCita { get; set; }    
       
        
        
    
    }

    public class AgendaViewModel : AgendaInputModel
    {
        public AgendaViewModel()
        {

        }
        public AgendaViewModel(Agenda agenda)
        {
            idPsicologo = agenda.idPsicologo;
            fechaDeseada = agenda.fechaDeseada;
            horaCita = agenda.horaCita;
            idAgenda = agenda.idAgenda;
           
        } 
        public int idAgenda { get; set; }
    
    }
}