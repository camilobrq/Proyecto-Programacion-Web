using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class AgendaInputModel
    {
        public string idPsicologo { get; set; }
        public DateTime fechaDeseada { get; set; }
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
            nombrePsicologo = agenda.nombrePsicologo;
            areaEspecializada=agenda.areaEspecializada;
            areaPsicologo=agenda.areaPsicologo;
        } 
        public int idAgenda { get; set; }
          public string nombrePsicologo { get; set; }
        public string areaEspecializada { get; set; }
        public string areaPsicologo { get; set; }
    }
}