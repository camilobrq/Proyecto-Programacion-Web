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
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Paciente);
        }

        [HttpGet]
      public ActionResult<IEnumerable<PacienteViewModel>> Gets()
      {
            var respuesta = _pacienteService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Pacientes.Select(p => new PacienteViewModel(p)));
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
            paciente.identificacion = pacienteInputModel.identificacion;
            paciente.nombre = pacienteInputModel.nombre;
            paciente.apellido = pacienteInputModel.apellido;
            paciente.edad = pacienteInputModel.edad;
            paciente.sexo = pacienteInputModel.sexo;
            paciente.telefono = pacienteInputModel.telefono;
            paciente.direccion = pacienteInputModel.direccion;
            paciente.correo = pacienteInputModel.correo;
            paciente.Eps = pacienteInputModel.Eps;
            return paciente;
        } 
    }
}