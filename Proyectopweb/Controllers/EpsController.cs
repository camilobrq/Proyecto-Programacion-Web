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
    
    [Route("api/[controller]")]
    [ApiController]
    public class EpsController : ControllerBase
    {
        private readonly EpsService _EpsService;
        private readonly IHubContext<SignalHub> _hubContext;
        public EpsController(ConsultorioContext context, IHubContext<SignalHub> hubContext)
        {
            _hubContext = hubContext;
            _EpsService = new EpsService(context);
        }

        
        [AllowAnonymous]
        [HttpGet]
        public List<string> GetList()
        {
            var respuesta = _EpsService.consultaEps();
            
            return respuesta;
            //return Ok(new List<PacienteViewModel>());
        }
        /*
        public ActionResult<List<EpsViewModel>> Gets()
        {
            var respuesta = _EpsService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Eps.Select(p => new EpsViewModel(p)));
            //return Ok(new List<PacienteViewModel>());
        }

        */
    }
}