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
               // var PsicologoBuscadoNombreUsuario = _context.psicologos.Find(psicologo.nombreUsuario);
                var PsicologoBuscadoIdentificacion = _context.psicologos.Find(psicologo.identificacion);
                if (/*PsicologoBuscadoNombreUsuario != null ||*/ PsicologoBuscadoIdentificacion != null)
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

        public List<Psicologo> ConsultarTodosLosPsicologos()
        {
            List<Psicologo> psicologos = _context.psicologos.ToList();
            return psicologos;
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
}

