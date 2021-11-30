using Datos;
using Entidad;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Logica
{
    public class EvaluacionService
    {
        private readonly ConsultorioContext _context;

        public EvaluacionService(ConsultorioContext context)
        {
            _context = context;
        }

        public EvaluacionGuardarResponse Guardar(Evaluacion evaluacion)
        {
            try
            {
                var Paciente=_context.pacientes.Find(evaluacion.paciente.identificacion);
                var Psicologo=_context.psicologos.Find(evaluacion.Psicologo.identificacion);
                
                if (Paciente== null && Psicologo==null)
                {
                    return new EvaluacionGuardarResponse($"No se encuentra registrada la persona en el sistema");
                  
                }
                evaluacion.paciente=Paciente;
                evaluacion.Psicologo=Psicologo;
                _context.evaluaciones.Add(evaluacion);
                _context.SaveChanges();
                return new EvaluacionGuardarResponse(evaluacion);
            }
            catch (Exception e)
            {
                return new EvaluacionGuardarResponse($"Error inesperado al Guardar: { e.Message}");
            }

        }
        public string Eliminar(string idEvaluacion)
        {
            try
            {
                var evaluacion = _context.evaluaciones.Find(idEvaluacion);
                if (evaluacion != null)
                {
                    _context.Remove(evaluacion);
                    _context.SaveChanges();
                    return $"Se Eliminó el registro de la cita {idEvaluacion}";
                }
                return $"No fue posible eliminar el registro, porque no existe una cita con el id {idEvaluacion}";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }
            
        }
        public EvaluacionConsultaResponse Consultar()
        {
            try
            {

                return new EvaluacionConsultaResponse(_context.evaluaciones.ToList());

            }
            catch (Exception e)
            {
                return new EvaluacionConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            
        }
        public EvaluacionBuscarResponse Buscar(string idEvaluacion)
        {
            try
            {
        
                var evaluacion = _context.evaluaciones.Find(idEvaluacion);
                if (evaluacion == null)
                {
                    
                    throw new EvaluacionNoEncontradaException("No se encontraró un registro con la identificacion Solicitada");
                }
                return new EvaluacionBuscarResponse(evaluacion);
            }
            catch (EvaluacionNoEncontradaException e)
            {
                return new EvaluacionBuscarResponse("Error al Buscar:" + e.Message);
            }
            catch (Exception e)
            {
                return new EvaluacionBuscarResponse("Error inesperado al Buscar:" + e.Message);
            }
            
        }
    }
     public class EvaluacionBuscarResponse
    {
        public Evaluacion Evaluacion { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public EvaluacionBuscarResponse(Evaluacion evaluacion)
        {
            Evaluacion = evaluacion;
            IsError = false;
        }
        public EvaluacionBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
     public class EvaluacionConsultaResponse
    {
        public List<Evaluacion> Evaluaciones { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public EvaluacionConsultaResponse(List<Evaluacion> evaluaciones)
        {
            Evaluaciones = evaluaciones;
            Error = false;
        }
        public EvaluacionConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
     public class EvaluacionGuardarResponse
    {
        public Evaluacion Evaluacion { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public EvaluacionGuardarResponse(Evaluacion evaluacion)
        {
            Evaluacion=evaluacion;
           
            IsError = false;
        }
        public EvaluacionGuardarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
    public class EvaluacionNoEncontradaException : Exception
    {
        public EvaluacionNoEncontradaException()
        {
        }

        public EvaluacionNoEncontradaException(string message) : base(message)
        {

        }
    }

}