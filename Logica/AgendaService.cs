using Datos;
using Entidad;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Logica
{
    public class AgendaService
    {
        private readonly ConsultorioContext _context;

        public AgendaService(ConsultorioContext context)
        {
            _context = context;
        }

        public AgendaGuardarResponse Guardar(Agenda agenda)
        {
            try
            {
               // var citaRepetida=_context.citas.Find(cita.idPaciente);
              
                var Psicologo=_context.psicologos.Find(agenda.psicologo.identificacion);
                if (Psicologo== null)
                {
                    return new AgendaGuardarResponse($"No se encuentra registrado el psicologo en el sistema");
                   
                }
               
                agenda.psicologo=Psicologo;
                _context.agendas.Add(agenda);
                _context.SaveChanges();
                
                
               
               
                return new AgendaGuardarResponse(agenda);
            }
            catch (Exception e)
            {
                return new AgendaGuardarResponse($"Error inesperado al Guardar: { e.Message}");
            }

        }
        public string Eliminar(string idAgenda)
        {
            try
            {
                var agenda = _context.agendas.Find(idAgenda);
                if (agenda != null)
                {
                    _context.Remove(agenda);
                    _context.SaveChanges();
                    return $"Se Eliminó el registro de la cita {idAgenda}";
                }
                return $"No fue posible eliminar el registro, porque no existe una cita con el id {idAgenda}";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }
            
        }
        public AgendaConsultaResponse Consultar()
        {
            try
            {

                return new AgendaConsultaResponse(_context.agendas.ToList());

            }
            catch (Exception e)
            {
                return new AgendaConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            
        }
        public AgendaBuscarResponse Buscar(string idAgenda)
        {
            try
            {
        
                var agenda = _context.agendas.Find(idAgenda);
                if (agenda == null)
                {
                    
                    throw new AgendaNoEncontradaException("No se encontraró un registro con la identificacion Solicitada");
                }
                return new AgendaBuscarResponse(agenda);
            }
            catch (AgendaNoEncontradaException e)
            {
                return new AgendaBuscarResponse("Error al Buscar:" + e.Message);
            }
            catch (Exception e)
            {
                return new AgendaBuscarResponse("Error inesperado al Buscar:" + e.Message);
            }
            
        }
    }
}
