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
    public class PsicologoController : ControllerBase
    {
        private readonly PsicologoService _psicologoService;
       
        public PsicologoController(ConsultorioContext context)
        {
            _psicologoService = new PsicologoService(context);
        }

        
        [HttpPost]
        public ActionResult<PsicologoViewModel> Guardar(PsicologoInputModel psicologoInputModel)
        {
            var psicologo = MapearaPsicologo(psicologoInputModel);
            var respuesta = _psicologoService.Guardar(psicologo);
            
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Psicologo);
        }

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
        private Psicologo MapearaPsicologo(PsicologoInputModel PsicologoInputModel)
        {
            var psicologo = new Psicologo();
           psicologo.tipoDocumento=PsicologoInputModel.tipoDocumento;
            psicologo.identificacion = PsicologoInputModel.identificacion;
            psicologo.nombre = PsicologoInputModel.nombre;
            psicologo.apellido = PsicologoInputModel.apellido;
            psicologo.fechaNacimiento=PsicologoInputModel.fechaNacimiento;
            psicologo.sexo = PsicologoInputModel.sexo;
            psicologo.telefono = PsicologoInputModel.telefono;
            psicologo.direccion = PsicologoInputModel.direccion;
            psicologo.correo = PsicologoInputModel.correo;
            psicologo.Universidad=PsicologoInputModel.Universidad;
           psicologo.fechaFinalizacion=PsicologoInputModel.fechaFinalizacion;
           psicologo.areaEspecializada=PsicologoInputModel.areaEspecializada;
           psicologo.mesesExperiencia=PsicologoInputModel.mesesExperiencia;
            psicologo.calcularEdad(psicologo.fechaNacimiento);
            return psicologo;
        } 
    }
}