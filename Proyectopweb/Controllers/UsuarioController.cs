using Datos;
using Entidad;
using Proyectopweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Logica;
using System.Collections.Generic;
using System.Linq;
using WebPulsaciones;
using Microsoft.Extensions.Options;
using WebPulsaciones.Config;
using Microsoft.AspNetCore.Authorization;

namespace Proyectopweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService usuarioService;
        private JwtService _jwtService;


        ConsultorioContext _context;

        public UsuarioController(ConsultorioContext context, IOptions<AppSetting> appSettings, JwtService jwtService)
        {
            _context = context;
            this.usuarioService = new UsuarioService(context);

           
            /*
                _context.usuarios.Add(new Entidad.Usuario() { nombreUsuario = "admin", contrasena = "admin", correo = "admin@gmail.com", estado = "AC", telefono = "31800000000", tipoUsuario="Administrador" });
                 var i = _context.SaveChanges();
            */
            //_jwtService= jwtService;
            _jwtService = new JwtService(appSettings);
            usuarioService = new UsuarioService(context);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(UsuarioInputModel model)
        {
            var user = usuarioService.Validate(model.nombreUsuario, model.contrasena);

            if (user == null)
            {
                ModelState.AddModelError("Acceso Denegado", "Username or password is incorrect");
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                return BadRequest(problemDetails);
            }
            var response = _jwtService.GenerateToken(user);

            return Ok(response);
        }



    }
}