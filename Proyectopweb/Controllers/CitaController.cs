using Datos;
using Entidad;
using Proyectopweb.Models;
using Microsoft.AspNetCore.Mvc;
using Logica;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
namespace Proyectopweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly CitaService _citaService;
       
        public CitaController(ConsultorioContext context)
        {
            _citaService = new CitaService(context);
        }

        
        [HttpPost]
        public ActionResult<CitaViewModel> Guardar(CitaInputModel citaInputModel)
        {
            var cita = MapearaCitas(citaInputModel);
            var respuesta = _citaService.Guardar(cita);
            
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Cita);
        }

        [HttpGet]
        public ActionResult<IEnumerable<CitaViewModel>> Gets()
        {
            var respuesta = _citaService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Citas.Select(p => new CitaViewModel(p)));
        }

        [HttpGet("byId")]
        public ActionResult<CitaViewModel> Gets(string id)
        {
            var respuesta = _citaService.Buscar(id);
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Cita);
        }
        private Cita MapearaCitas(CitaInputModel citaInputModel)
        {
            var cita = new Cita{
            idPaciente = citaInputModel.idPaciente,
            tiposSolicitud = citaInputModel.tiposSolicitud,
            fechaDeseada = citaInputModel.fechaDeseada,
            
            paciente=new Paciente{
                identificacion=citaInputModel.idPaciente,
                
            },
            };
           
            return cita;
        } 
    }
}