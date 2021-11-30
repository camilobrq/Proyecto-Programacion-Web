using Datos;
using Entidad;
using System;
using System.Linq;

namespace Logica
{
    public class UsuarioService
    {
        private readonly ConsultorioContext _context;

        public UsuarioService(ConsultorioContext context)=> _context = context;

        public Usuario Validate(string userName, string password) 
        {
            return _context.usuarios.Where(t => t.nombreUsuario == userName && t.contrasena == password && t.estado == "AC").FirstOrDefault();
        }
         public GuardarUsuarioResponse Guardar(Usuario usuario)
        {
            try
            {
               /* var PacienteBuscado = _context.pacientes.Find(paciente.nombreUsuario);*/
                var BuscadoUser = _context.pacientes.Find(usuario.nombreUsuario);
                if (/*PacienteBuscado != null ||/*/ BuscadoUser != null)
                {
                    return new GuardarUsuarioResponse("Error, el paciente ya esta registrado o el nombre de usuario no esta Disponible.");
                }
                _context.usuarios.Add(usuario);
                _context.SaveChanges();
                return new GuardarUsuarioResponse(usuario);
            }
            catch (Exception e)
            {
                return new GuardarUsuarioResponse($"Error de la aplicacion: {e.Message}");
            }
        }
        
    }
     public class GuardarUsuarioResponse
    {
        public Usuario usuario { get; set; }
        public GuardarUsuarioResponse(Usuario usuario)
        {
            Error = false;
            this.usuario = usuario;
        }
        public GuardarUsuarioResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        

    }
}
