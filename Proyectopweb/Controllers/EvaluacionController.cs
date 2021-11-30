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
    public class EvaluacionController : ControllerBase
    {
        private readonly EvaluacionService _evaluacionService;
       
        public EvaluacionController(ConsultorioContext context)
        {
            _evaluacionService = new EvaluacionService(context);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult<EvaluacionViewModel> Guardar(EvaluacionInputModel evaluacionInputModel)
        {
            var evaluacion = MapearaEvaluacion(evaluacionInputModel);
            var respuesta = _evaluacionService.Guardar(evaluacion);
            
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Evaluacion);
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<EvaluacionViewModel>> Gets()
        {
            var respuesta = _evaluacionService.Consultar();
            if (respuesta.Error == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Evaluaciones.Select(p => new EvaluacionViewModel(p)));
        }
        [AllowAnonymous]
        [HttpGet("byId")]
        public ActionResult<EvaluacionViewModel> Gets(string id)
        {
            var respuesta = _evaluacionService.Buscar(id);
            if (respuesta.IsError == true)
            {
                return BadRequest(respuesta.Mensaje);
            }
            return Ok(respuesta.Evaluacion);
        }
        
        private Evaluacion MapearaEvaluacion(EvaluacionInputModel evaluacionInputModel)
        {
            var evaluacion = new Evaluacion{
            identificacionPaciente = evaluacionInputModel.identificacionPaciente,
            identificacionPsicologo = evaluacionInputModel.identificacionPsicologo,
            diagnostico=evaluacionInputModel.diagnostico, 
            ocupacion = evaluacionInputModel.ocupacion,
            consulta = evaluacionInputModel.consulta,
            observacion = evaluacionInputModel.observacion,
            prueba = evaluacionInputModel.prueba,
            analisis = evaluacionInputModel.analisis,
            pronostico = evaluacionInputModel.pronostico,
            recomendacion = evaluacionInputModel.recomendacion,
            paciente=new Paciente{
                identificacion=evaluacionInputModel.identificacionPaciente,
                
            },
            Psicologo=new Psicologo{
                identificacion=evaluacionInputModel.identificacionPsicologo,
                
            },
            };
           
            return evaluacion;
        } 
    }
}