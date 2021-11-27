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
    public class PsicologoController : ControllerBase
    {
        private readonly PsicologoService _psicologoService;

        public PsicologoController(ConsultorioContext context)
        {
           this._psicologoService  = new PsicologoService(context);
        }


        [HttpPost]
        public ActionResult<PsicologoViewModel> Guardar(PsicologoInputModel psicologoInputModel)
        {
            var psicologo = MapearPsicologo(psicologoInputModel);
            var respuesta = _psicologoService.Guardar(psicologo);

            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
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
                psicologo.nombreUsuario = psicologoInputModel.nombreUsuario;
                psicologo.contraseña = psicologoInputModel.contraseña;
                psicologo.tipoUsuario = psicologoInputModel.tipoUsuario;
                psicologo.tipoDocumento = psicologoInputModel.tipoDocumento;
                psicologo.identificacion = psicologoInputModel.identificacion;
                psicologo.nombre = psicologoInputModel.nombre;
                psicologo.apellido = psicologoInputModel.apellido;
                psicologo.fechaNacimiento = psicologoInputModel.fechaNacimiento;
                psicologo.sexo = psicologoInputModel.sexo;
                psicologo.telefono = psicologoInputModel.telefono;
                psicologo.direccion = psicologoInputModel.direccion;
                psicologo.correo = psicologoInputModel.correo;
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