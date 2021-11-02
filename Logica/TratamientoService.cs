using Datos;
using Entidad;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Logica
{
    public class TratamientoService
    {
        private readonly ConsultorioContext _context;

        public TratamientoService(ConsultorioContext context)
        {
            _context = context;
        }

        public TratamientoGuardarResponse Guardar(Tratamiento tratamiento)
        {
            try
            {
                var Paciente=_context.pacientes.Find(tratamiento.paciente.identificacion);
                var Psicologo=_context.psicologos.Find(tratamiento.Psicologo.identificacion);
                if (Paciente== null && Psicologo==null)
                {
                    return new TratamientoGuardarResponse($"No se encuentra registrada la persona en el sistema");
                  
                }
                tratamiento.paciente=Paciente;
                tratamiento.Psicologo=Psicologo;
                _context.tratamientos.Add(tratamiento);
                _context.SaveChanges();
                return new TratamientoGuardarResponse(tratamiento);
            }
            catch (Exception e)
            {
                return new TratamientoGuardarResponse($"Error inesperado al Guardar: { e.Message}");
            }

        }
        public string Eliminar(string idTratamiento)
        {
            try
            {
                var Tratamiento = _context.tratamientos.Find(idTratamiento);
                if (Tratamiento != null)
                {
                    _context.Remove(Tratamiento);
                    _context.SaveChanges();
                    return $"Se Eliminó el registro de la cita {idTratamiento}";
                }
                return $"No fue posible eliminar el registro, porque no existe una cita con el id {idTratamiento}";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }
            
        }
        public TratamientoConsultaResponse Consultar()
        {
            try
            {

                return new TratamientoConsultaResponse(_context.tratamientos.ToList());

            }
            catch (Exception e)
            {
                return new TratamientoConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            
        }
        public TratamientoBuscarResponse Buscar(string idTratamiento)
        {
            try
            {
        
                var Tratamiento = _context.tratamientos.Find(idTratamiento);
                if (Tratamiento == null)
                {
                    
                    throw new TratamientoNoEncontradaException("No se encontraró un registro con la identificacion Solicitada");
                }
                return new TratamientoBuscarResponse(Tratamiento);
            }
            catch (TratamientoNoEncontradaException e)
            {
                return new TratamientoBuscarResponse("Error al Buscar:" + e.Message);
            }
            catch (Exception e)
            {
                return new TratamientoBuscarResponse("Error inesperado al Buscar:" + e.Message);
            }
            
        }
    }
}
