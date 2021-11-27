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
    public class TratamientoController : ControllerBase
    {
        private readonly TratamientoService tratamientoService;


        public TratamientoController(ConsultorioContext context)
        {
            this.tratamientoService = new TratamientoService(context);
        }


        private Tratamiento MapearTratamiento(TratamientoInputModel tratamientoInputModel)
        {
            var tratamiento = new Tratamiento();
            {
                tratamiento.idTratamiento = tratamientoInputModel.idTratamiento;
                tratamiento.nombreTratamiento = tratamientoInputModel.nombreTratamiento;
                tratamiento.descripcionTratamiento = tratamientoInputModel.descripcionTratamiento;

            }
            return tratamiento;
        }

        [HttpPost]
        public ActionResult<TratamientoViewModel> Guardar(TratamientoInputModel tratamientoInputModel)
        {
            var tratamiento = MapearTratamiento(tratamientoInputModel);
            var respuesta = this.tratamientoService.Guardar(tratamiento);

            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.tratamiento);
        }

        [HttpGet]
        public IEnumerable<TratamientoViewModel> Gets()
        {
            var tratamientos = this.tratamientoService.ConsultarTodosLosTratamientos().Select(p => new TratamientoViewModel(p));
            return tratamientos;

        }


    }
}