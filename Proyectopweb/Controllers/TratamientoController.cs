using Datos;
using Entidad;
using Proyectopweb.Models;
using Microsoft.AspNetCore.Mvc;
using Logica;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Proyectopweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TratamientoController : ControllerBase
    {
        private readonly TratamientoService _tratamientoService;
       
        public TratamientoController(ConsultorioContext context)
        {
            _tratamientoService = new TratamientoService(context);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult<TratamientoViewModel> Guardar(TratamientoInputModel tratamientoInputModel)
        {
            var tratamiento = MapearaTratamiento(tratamientoInputModel);
            var respuesta = _tratamientoService.Guardar(tratamiento);
            
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Tratamiento);
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<TratamientoViewModel>> Gets()
        {
            var respuesta = _tratamientoService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Tratamientos.Select(p => new TratamientoViewModel(p)));
        }

        [HttpGet("byId")]
        public ActionResult<TratamientoViewModel> Gets(string id)
        {
            var respuesta = _tratamientoService.Buscar(id);
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Tratamiento);
        }
        private Tratamiento MapearaTratamiento(TratamientoInputModel tratamientoInputModel)
        {
            var tratamiento = new Tratamiento{
            identificacionPaciente = tratamientoInputModel.identificacionPaciente,
            identificacionPsicologo = tratamientoInputModel.identificacionPsicologo,
            fecha = tratamientoInputModel.fecha,
            medicacion=tratamientoInputModel.medicacion,
            tratamientoPaso=tratamientoInputModel.tratamientoPaso,
            codigo_3=tratamientoInputModel.codigo_3,
            codigo_4=tratamientoInputModel.codigo_4,
            descripcion_3=tratamientoInputModel.descripcion_3,
            descripcion_4=tratamientoInputModel.descripcion_4,
            paciente=new Paciente{
                identificacion=tratamientoInputModel.identificacionPaciente,
                
            },
            Psicologo=new Psicologo{
                identificacion=tratamientoInputModel.identificacionPsicologo,
                
            },
            };
           
            return tratamiento;
        } 
    }
}