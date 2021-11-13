using Datos;
using Entidad;
using Proyectopweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Logica;
using System.Collections.Generic;
using System.Linq;
namespace Proyectopweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly PacienteService _pacienteService;
       
        public PacienteController(ConsultorioContext context)
        {
            _pacienteService = new PacienteService(context);
        }

        
        [HttpPost]
        public ActionResult<PacienteViewModel> Guardar(PacienteInputModel pacienteInputModel)
        {
            var paciente = MapearaPaciente(pacienteInputModel);
            var respuesta = _pacienteService.Guardar(paciente);
            
            if (respuesta.IsError == true)
            {
                ModelState.AddModelError("Guardar Paciente", respuesta.Mensaje);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Paciente);
        }

        [HttpGet]
        public  ActionResult<List<PacienteViewModel>> Gets()
        {
            var respuesta = _pacienteService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Pacientes.Select(p => new PacienteViewModel(p)));
            //return Ok(new List<PacienteViewModel>());
        }

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
            var paciente = new Paciente();
            paciente.tipoDocumento=pacienteInputModel.tipoDocumento;
            paciente.identificacion = pacienteInputModel.identificacion;
            paciente.nombre = pacienteInputModel.nombre;
            paciente.apellido = pacienteInputModel.apellido;
            paciente.fechaNacimiento=pacienteInputModel.fechaNacimiento;
            paciente.sexo = pacienteInputModel.sexo;
            paciente.telefono = pacienteInputModel.telefono;
            paciente.direccion = pacienteInputModel.direccion;
            paciente.correo = pacienteInputModel.correo;
            paciente.Eps = pacienteInputModel.Eps;
            paciente.calcularEdad(paciente.fechaNacimiento);
            return paciente;
        } 
    }
}