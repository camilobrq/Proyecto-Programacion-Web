using Datos;
using Entidad;
using Proyectopweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Logica;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Proyectopweb.Hubs;
using Microsoft.AspNetCore.Authorization;

namespace Proyectopweb.Controllers
{
    [Authorize(Roles ="Paciente")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly PacienteService _pacienteService;
        private readonly IHubContext<SignalHub> _hubContext;
        public PacienteController(ConsultorioContext context, IHubContext<SignalHub> hubContext)
        {
            _hubContext = hubContext;
            _pacienteService = new PacienteService(context);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<PacienteViewModel>> Post(PacienteInputModel pacienteInputModel)
        {
            var paciente = MapearaPaciente(pacienteInputModel);
            var respuesta = _pacienteService.Guardar(paciente);

            if (respuesta.Error == true)
            {
                ModelState.AddModelError("Guardar Paciente", respuesta.Mensaje);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                await _hubContext.Clients.All.SendAsync("SignalMessageReceived", pacienteInputModel);
                return BadRequest(problemDetails);
            }
            return Ok(respuesta.Paciente);
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<List<PacienteViewModel>> Gets()
        {
            var respuesta = _pacienteService.ConsultarTodosLosPacientes();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Pacientes.Select(p => new PacienteViewModel(p)));
            //return Ok(new List<PacienteViewModel>());
        }
        [AllowAnonymous]
        [HttpGet("byId")]
        public ActionResult<PacienteViewModel> Gets(string id)
        {
            var respuesta = _pacienteService.Buscar(id);
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Paciente);
        }
        private Paciente MapearaPaciente(PacienteInputModel pacienteInputModel)
        {
            var paciente = new Paciente()
            {
                tipoDocumento = pacienteInputModel.tipoDocumento,
                identificacion = pacienteInputModel.identificacion,
                nombre = pacienteInputModel.nombre,
                apellido = pacienteInputModel.apellido,
                fechaNacimiento = pacienteInputModel.fechaNacimiento,
                sexo = pacienteInputModel.sexo,
                direccion = pacienteInputModel.direccion,
                Eps = pacienteInputModel.Eps,
                
                usuario=new Usuario{
                    tipoUsuario="Paciente",
                    nombreUsuario=pacienteInputModel.nombreUsuario,
                    contrasena=pacienteInputModel.contrasena,
                    correo=pacienteInputModel.correo,
                    estado="Ac",
                    telefono=pacienteInputModel.telefono,

                }

            };
            paciente.calcularEdad(paciente.fechaNacimiento);


            return paciente;
        }
    }
}