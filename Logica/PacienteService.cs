using Datos;
using Entidad;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Logica
{
    public class PacienteService
    {
        private readonly ConsultorioContext _context;

        public PacienteService(ConsultorioContext context)
        {
            _context = context;
        }

        public PacienteGuardarResponse Guardar(Paciente paciente)
        {
            try
            {

                if (_context.pacientes.Find(paciente.identificacion)== null)
                {
                    _context.pacientes.Add(paciente);
                    _context.SaveChanges();
                    return new PacienteGuardarResponse(paciente);
                }
                return new PacienteGuardarResponse($"No fue posible Guardar la información, porque ya existe un registro");
            }
            catch (Exception e)
            {
                return new PacienteGuardarResponse($"Error inesperado al Guardar: { e.Message}");
            }

        }
        public string Eliminar(string identificacion)
        {
            try
            {
                var paciente = _context.pacientes.Find(identificacion);
                if (paciente != null)
                {
                    _context.Remove(paciente);
                    _context.SaveChanges();
                    return $"Se Eliminó el registro de la paciente con identificacion{identificacion}";
                }
                return $"No fue posible eliminar el registro, porque no existe la paciente con la identificacion {identificacion}";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }
            
        }
        public PacienteConsultaResponse Consultar()
        {
            try
            {

                return new PacienteConsultaResponse(_context.pacientes.ToList());

            }
            catch (Exception e)
            {
                return new PacienteConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            
        }
        public PacienteBuscarResponse Buscar(string identificacion)
        {
            try
            {
        
                var paciente = _context.pacientes.Find(identificacion);
                if (paciente == null)
                {
                    
                    throw new PacienteNoEncontradaException("No se encontraró un registro con la identificacion Solicitada");
                }
                return new PacienteBuscarResponse(paciente);
            }
            catch (PacienteNoEncontradaException e)
            {
                return new PacienteBuscarResponse("Error al Buscar:" + e.Message);
            }
            catch (Exception e)
            {
                return new PacienteBuscarResponse("Error inesperado al Buscar:" + e.Message);
            }
            
        }
    }
}
