using Datos;
using Entidad;
using Proyectopweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Logica;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.SignalR;
using Proyectopweb.Hubs;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Proyectopweb.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PsicologoController : ControllerBase
    {
        private readonly PsicologoService _psicologoService;
        private readonly IHubContext<SignalHub> _hubContext;
        public PsicologoController(ConsultorioContext context,IHubContext<SignalHub> hubContext)
        {
             _hubContext=hubContext;
           this._psicologoService  = new PsicologoService(context);
        }


        [HttpPost]
        public async Task<ActionResult<PsicologoViewModel>> Guardar(PsicologoInputModel psicologoInputModel)
        {
            var psicologo = MapearPsicologo(psicologoInputModel);
            var respuesta = _psicologoService.Guardar(psicologo);

            if (respuesta.Error == true)
            {
                ModelState.AddModelError("Guardar Paciente", respuesta.Mensaje);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                await _hubContext.Clients.All.SendAsync("SignalMessageReceived",psicologoInputModel);
                return BadRequest(problemDetails);
            }
            return Ok(respuesta.psicologo);
        }

        [HttpGet]
        public IEnumerable<PsicologoViewModel> Gets()
        {
            var psicologos = this._psicologoService.ConsultarTodosLosPsicologos().Select(p => new PsicologoViewModel(p));
            return psicologos;

        }

        private Psicologo MapearPsicologo(PsicologoInputModel psicologoInputModel)
        {
            var psicologo = new Psicologo();
            {
               
                psicologo.tipoDocumento = psicologoInputModel.tipoDocumento;
                psicologo.identificacion = psicologoInputModel.identificacion;
                psicologo.nombre = psicologoInputModel.nombre;
                psicologo.apellido = psicologoInputModel.apellido;
                psicologo.fechaNacimiento = psicologoInputModel.fechaNacimiento;
                psicologo.sexo = psicologoInputModel.sexo;
               
                psicologo.direccion = psicologoInputModel.direccion;
                
                //psicologo.calcularEdad();
                //psicologo.edad = psicologoInputModel.edad;
                psicologo.UniversidadEgreso = psicologoInputModel.UniversidadEgreso;
                psicologo.fechaFinalizacion = psicologoInputModel.fechaFinalizacion;
                psicologo.areaEspecializada = psicologoInputModel.areaEspecializada;
                psicologo.areaPsicologo = psicologoInputModel.areaPsicologo;
                psicologo.mesesExperiencia = psicologoInputModel.mesesExperiencia;

            }
            return psicologo;
        }
    }
}