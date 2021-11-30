using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;


namespace Logica
{
    public class PsicologoService
    {

        private readonly ConsultorioContext _context;


        public PsicologoService(ConsultorioContext context)
        {
            _context = context;
        }

        public GuardarPsicologoResponse Guardar(Psicologo psicologo)
        {
            try
            {
               
                var PsicologoBuscadoIdentificacion = _context.psicologos.Find(psicologo.identificacion);
                if (PsicologoBuscadoIdentificacion != null)
                {
                    return new GuardarPsicologoResponse("Error, ya existe un psicologo registrado con el nombre de usuario o el psicologo ya esta registrado");
                }
               // psicologo.calcularEdad(psicologo.fechaNacimiento);
                _context.psicologos.Add(psicologo);
                _context.SaveChanges();
                return new GuardarPsicologoResponse(psicologo);
            }
            catch (Exception e)
            {
                return new GuardarPsicologoResponse($"Error de la aplicacion: {e.Message}");
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


    public class GuardarPsicologoResponse
    {
        public GuardarPsicologoResponse(Psicologo psicologo)
        {
            Error = false;
            this.psicologo = psicologo;
        }
        public GuardarPsicologoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Psicologo psicologo { get; set; }

    }
    public class PsicologoBuscarResponse
    {
        public Psicologo Psicologo { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public PsicologoBuscarResponse(Psicologo psicologo)
        {
            Psicologo = psicologo;
            IsError = false;
        }
        public PsicologoBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
     public class PsicologoConsultaResponse
    {
        public List<Psicologo> Psicologo { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public PsicologoConsultaResponse(List<Psicologo> psicologo)
        {
            Psicologo = psicologo;
            Error = false;
        }
        public PsicologoConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
     public class PsicologoNoEncontradaException : Exception
    {
        public PsicologoNoEncontradaException()
        {
        }

        public PsicologoNoEncontradaException(string message) : base(message)
        {

        }
    }
    public class CitaBuscarResponse
    {
        public Cita Cita { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public CitaBuscarResponse(Cita cita)
        {
            Cita = cita;
            IsError = false;
        }
        public CitaBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
     public class CitaNoEncontradaException : Exception
    {
        public CitaNoEncontradaException()
        {
        }

        public CitaNoEncontradaException(string message) : base(message)
        {

        }
    }
}

