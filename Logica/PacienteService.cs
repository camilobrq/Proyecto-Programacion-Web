using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class PacienteService
    {
        private readonly ConsultorioContext _context;


        public PacienteService(ConsultorioContext context)
        {
            _context = context;
        }

        public GuardarPacienteResponse Guardar(Paciente paciente)
        {
            try
            {
               /* var PacienteBuscado = _context.pacientes.Find(paciente.nombreUsuario);*/
                var PacienteBuscadoIdentificacion = _context.pacientes.Find(paciente.identificacion);
                if (/*PacienteBuscado != null ||/*/ PacienteBuscadoIdentificacion != null)
                {
                    return new GuardarPacienteResponse("Error, el paciente ya esta registrado o el nombre de usuario no esta Disponible.");
                }
                _context.pacientes.Add(paciente);
                _context.SaveChanges();
                return new GuardarPacienteResponse(paciente);
            }
            catch (Exception e)
            {
                return new GuardarPacienteResponse($"Error de la aplicacion: {e.Message}");
            }
        }

        public string Eliminar(string nombreusuario)
        {
            try
            {
                var paciente = _context.pacientes.Find(nombreusuario);
                if (paciente != null)
                {
                    _context.Remove(paciente);
                    _context.SaveChanges();
                    return $"Se Eliminó el Paciente con el nombre de usuario: {nombreusuario}";
                }
                return $"No fue posible eliminar el registro, porque no existe el paciente con el nombre de usuario: {nombreusuario}";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }

        }

        public PacienteConsultaResponse ConsultarTodosLosPacientes()
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

                    return new PacienteBuscarResponse("No se encontraró un registro con la identificacion Solicitada");
                }
                return new PacienteBuscarResponse(paciente);
            }
            catch (Exception e)
            {
                return new PacienteBuscarResponse("Error al Buscar:" + e.Message);
            }
        }

    }



    public class GuardarPacienteResponse
    {
        public GuardarPacienteResponse(Paciente paciente)
        {
            Error = false;
            this.Paciente = paciente;
        }
        public GuardarPacienteResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Paciente Paciente { get; set; }

    }

    public class PacienteConsultaResponse
    {
        public List<Paciente> Pacientes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public PacienteConsultaResponse(List<Paciente> pacientes)
        {
            Pacientes = pacientes;
            Error = false;
        }
        public PacienteConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }

    public class PacienteBuscarResponse
    {
        public Paciente Paciente { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public PacienteBuscarResponse(Paciente paciente)
        {
            Paciente = paciente;
            IsError = false;
        }
        public PacienteBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }

}