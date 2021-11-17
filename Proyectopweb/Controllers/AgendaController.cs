using Microsoft.AspNetCore.Mvc;
using Logica;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Proyectopweb.Models;
using Entidad;

namespace Proyectopweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly AgendaService _agendaService;

        public AgendaController(ConsultorioContext context)
        {
            _agendaService = new AgendaService(context);
        }


        [HttpPost]
        public ActionResult<AgendaViewModel> Guardar(AgendaInputModel AgendaInputModel)
        {
            
            var agenda = MapearaAgenda(AgendaInputModel);
            var respuesta = _agendaService.Guardar(agenda);

            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Agenda);
        }

        [HttpGet]
        public ActionResult<IEnumerable<AgendaViewModel>> Gets()
        {
            var respuesta = _agendaService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Agendas.Select(p => new AgendaViewModel(p)));
        }

        [HttpGet("byId")]
        public ActionResult<AgendaViewModel> Gets(string id)
        {
            var respuesta = _agendaService.Buscar(id);
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Agenda);
        }
        private Agenda MapearaAgenda(AgendaInputModel AgendaInputModel)
        {
           
           
            var agenda = new Agenda
            {
                idPsicologo = AgendaInputModel.idPsicologo,
                fechaDeseada = AgendaInputModel.fechaDeseada,
                horaCita = AgendaInputModel.horaCita,
                psicologo = new Psicologo
                {
                identificacion = AgendaInputModel.idPsicologo,
                
                },
                 
               
            };

            return agenda;
        }
    

    }
}