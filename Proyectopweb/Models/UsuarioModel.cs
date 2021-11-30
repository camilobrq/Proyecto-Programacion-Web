using System;
using System.ComponentModel.DataAnnotations;
using Entidad;
using Proyectopweb;
namespace Proyectopweb.Models
{
    public class UsuarioInputModel
    {
        [Required]
        public string nombreUsuario { get; set; }
        [Required]
        public string contrasena { get; set; }


    }

    public class UsuarioViewModel : UsuarioInputModel
    {
        public UsuarioViewModel()
        {

        }
        public string nombreUsuario { get; set; }
        public string tipoUsuario { get; set; }
        public string estado { get; set; }
        public string Token { get; set; }
    }
}