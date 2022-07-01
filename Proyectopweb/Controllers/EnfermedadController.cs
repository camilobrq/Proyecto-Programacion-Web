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
    public class EnfermedadController : ControllerBase
    {
        
        private readonly EnfermedadService _enfermedadgoService;
        public EnfermedadController(ConsultorioContext context)
        {
            _enfermedadgoService = new EnfermedadService(context);
        }

        [HttpGet]
        public ActionResult<List<EnfermedadViewModel>> GetConsulta()
        {
            var respuesta = _enfermedadgoService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Enfermedades.Select(p => new EnfermedadViewModel(p)));
            //return Ok(new List<PacienteViewModel>());
        }

        [HttpGet("codigo3")]
        public List<string> Gets()
        {
            var respuesta = _enfermedadgoService.ListaCodigo3();
           
            return respuesta;
        }
         [HttpGet("codigo4")]
        public List<string> GetCodigo(string codigo3)
        {
            var respuesta = _enfermedadgoService.ListaCodigo4(codigo3);
           
            return respuesta;
        }
        [HttpGet("listaDescripcion3")]
        public List<string> Gets(string codigo3)
        {
            var respuesta = _enfermedadgoService.ListaDescripcion3(codigo3);
           
            return respuesta;
        }
       
        [HttpGet("listaDescripcion4")]
        public List<string> GetLis(string codigo4)
        {
            var respuesta = _enfermedadgoService.ListaDescripcion4(codigo4);
           
            return respuesta;
        }
    }
}