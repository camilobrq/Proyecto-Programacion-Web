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

    public class AdministradorController : ControllerBase
    {
        private readonly AdministradorService administradorService;

        public AdministradorController(ConsultorioContext context)
        {
            this.administradorService = new AdministradorService(context);
        }

        [HttpPost]
        public ActionResult<AdministradorViewModel> Guardar(AdministradorInputModel administradorInputModel)
        {
            var administrador = MapearAdministrador(administradorInputModel);
            var respuesta = this.administradorService.Guardar(administrador);

            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.administrador);
        }

        [HttpGet]
        public IEnumerable<AdministradorViewModel> Gets()
        {
            var administradores = this.administradorService.ConsultarTodosLosAdministradores().Select(p => new AdministradorViewModel(p));
            return administradores;

        }

        private Administrador MapearAdministrador(AdministradorInputModel administradorInputModel)
        {
            var administrador = new Administrador();
            {
                administrador.nombreUsuario = administradorInputModel.nombreUsuario;
                administrador.contrasena = administradorInputModel.contraseña;
                administrador.tipoUsuario = administradorInputModel.tipoUsuario;
               
            }
            return administrador;
        }


    }
}
