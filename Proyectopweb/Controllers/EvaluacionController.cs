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
    public class EvaluacionController : ControllerBase
    {
        private readonly EvaluacionService _evaluacionService;
       
        public EvaluacionController(ConsultorioContext context)
        {
            _evaluacionService = new EvaluacionService(context);
        }

        
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
            fecha = evaluacionInputModel.fecha,
            diagnostico=evaluacionInputModel.diagnostico,
            nombrePaciente = evaluacionInputModel.nombrePaciente,
            ocupacion = evaluacionInputModel.ocupacion,
            lugar = evaluacionInputModel.lugar,
            nombrePsicologo = evaluacionInputModel.nombrePsicologo,
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