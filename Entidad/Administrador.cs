using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Administrador: Usuario
    {
        public Administrador() {
            this.tipoUsuario = "Administrador";
        }
    }
}
