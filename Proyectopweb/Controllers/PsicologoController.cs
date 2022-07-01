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

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<PsicologoViewModel>> Guardar(PsicologoInputModel psicologoInputModel)
        {
            var psicologo = MapearPsicologo(psicologoInputModel);
            var respuesta = _psicologoService.Guardar(psicologo);

            if (respuesta.Error == true)
            {
                ModelState.AddModelError("Guardar Psicologo", respuesta.Mensaje);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                await _hubContext.Clients.All.SendAsync("SignalMessageReceived",psicologoInputModel);
                return BadRequest(problemDetails);
            }
            return Ok(respuesta.psicologo);
        }

        [AllowAnonymous]
         [HttpGet]
      public ActionResult<IEnumerable<PsicologoViewModel>> Gets()
      {
            var respuesta = _psicologoService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Psicologo.Select(p => new PsicologoViewModel(p)));
      }
      [AllowAnonymous]
        [HttpGet("byId")]
        public ActionResult<PsicologoViewModel> Gets(string id)
        {
           var respuesta = _psicologoService.Buscar(id);
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Psicologo);
        }
        private Psicologo MapearPsicologo(PsicologoInputModel PsicologoInputModel)
        {
            var psicologo = new Psicologo(){
            tipoDocumento=PsicologoInputModel.tipoDocumento,
            identificacion = PsicologoInputModel.identificacion,
            nombre = PsicologoInputModel.nombre,
            apellido = PsicologoInputModel.apellido,
            fechaNacimiento=PsicologoInputModel.fechaNacimiento,
            sexo = PsicologoInputModel.sexo,
            direccion = PsicologoInputModel.direccion,
            UniversidadEgreso=PsicologoInputModel.UniversidadEgreso,
           fechaFinalizacion=PsicologoInputModel.fechaFinalizacion,
           areaEspecializada=PsicologoInputModel.areaEspecializada,
           mesesExperiencia=PsicologoInputModel.mesesExperiencia
           ,
            usuario=new Usuario{
                    tipoUsuario="Psicologo",
                    nombreUsuario=PsicologoInputModel.nombreUsuario,
                    contrasena=PsicologoInputModel.contrasena,
                    correo=PsicologoInputModel.correo,
                    estado="Ac",
                    telefono=PsicologoInputModel.telefono,

            },


            };
                    
            psicologo.calcularEdad(psicologo.fechaNacimiento);
            return psicologo;
        }
    }
}