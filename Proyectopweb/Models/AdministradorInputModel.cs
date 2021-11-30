using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class AdministradorInputModel
    {


        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string tipoUsuario { get; set; }
       
    }

    public class AdministradorViewModel : AdministradorInputModel
    {
        public AdministradorViewModel(Administrador administrador)
        {
            nombreUsuario = administrador.nombreUsuario;
            contraseña = administrador.contrasena;
            tipoUsuario = administrador.tipoUsuario;
            


        }

    }
}
