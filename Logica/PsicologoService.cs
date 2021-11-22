using Datos;
using Entidad;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Logica
{
    public class PsicologoService
    {
        private readonly ConsultorioContext _context;

        public PsicologoService(ConsultorioContext context)
        {
            _context = context;
        }

        public PsicologoGuardarResponse Guardar(Psicologo psicologo)
        {
            try
            {

                if (_context.psicologos.Find(psicologo.identificacion)== null)
                {
                    _context.psicologos.Add(psicologo);
                    _context.SaveChanges();
                    return new PsicologoGuardarResponse(psicologo);
                }
                return new PsicologoGuardarResponse($"No fue posible Guardar la información, porque ya existe un registro");
            }
            catch (Exception e)
            {
                return new PsicologoGuardarResponse($"Error inesperado al Guardar: { e.Message}");
            }

        }
        public string Eliminar(string identificacion)
        {
            try
            {
                var Psicologo = _context.psicologos.Find(identificacion);
                if (Psicologo != null)
                {
                    _context.Remove(Psicologo);
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
        public PsicologoConsultaResponse Consultar()
        { 
            try
            {

                return new PsicologoConsultaResponse(_context.psicologos.ToList());

            }
            catch (Exception e)
            {
                return new PsicologoConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            
        }
        public PsicologoBuscarResponse Buscar(string identificacion)
        {
            try
            {
        
                var Psicologo = _context.psicologos.Find(identificacion);
                if (Psicologo == null)
                {
                    
                    throw new PsicologoNoEncontradaException("No se encontraró un registro con la identificacion Solicitada");
                }
                return new PsicologoBuscarResponse(Psicologo);
            }
            catch (PsicologoNoEncontradaException e)
            {
                return new PsicologoBuscarResponse("Error al Buscar:" + e.Message);
            }
            catch (Exception e)
            {
                return new PsicologoBuscarResponse("Error inesperado al Buscar:" + e.Message);
            }
            
        }
        public CitaBuscarResponse BuscarTerapia(string tipoCita)
        {
            try
            {
        
                var cita = _context.citas.Find(tipoCita);
                if (cita == null)
                {
                    
                    throw new CitaNoEncontradaException("No se encontraró un registro con la identificacion Solicitada");
                }
                return new CitaBuscarResponse(cita);
            }
            catch (CitaNoEncontradaException e)
            {
                return new CitaBuscarResponse("Error al Buscar:" + e.Message);
            }
            catch (Exception e)
            {
                return new CitaBuscarResponse("Error inesperado al Buscar:" + e.Message);
            }
            
        }
    }
}
