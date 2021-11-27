using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class AdministradorService
    {

        private readonly ConsultorioContext _context;


        public AdministradorService(ConsultorioContext context)
        {
            _context = context;
        }

        public GuardarAdministradorResponse Guardar(Administrador administrador)
        {
            try
            {
                var administradorBuscadoNombreUsuario = _context.administradores.Find(administrador.nombreUsuario);
                if (administradorBuscadoNombreUsuario != null)
                {
                    return new GuardarAdministradorResponse("Error, ya existe un administrador registrado con el nombre de usuario");
                }
                _context.administradores.Add(administrador);
                _context.SaveChanges();
                return new GuardarAdministradorResponse(administrador);
            }
            catch (Exception e)
            {
                return new GuardarAdministradorResponse($"Error de la aplicacion: {e.Message}");
            }
        }

        public List<Administrador> ConsultarTodosLosAdministradores()
        {
            List<Administrador> administradores = _context.administradores.ToList();
            return administradores;
        }
    }


    public class GuardarAdministradorResponse
    {
        public GuardarAdministradorResponse(Administrador administrador)
        {
            Error = false;
            this.administrador = administrador;
        }
        public GuardarAdministradorResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Administrador administrador { get; set; }

    }
}

