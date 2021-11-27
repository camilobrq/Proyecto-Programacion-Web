using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;

namespace Proyectopweb.Models
{
    public class PsicologoInputModel
    {
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string tipoUsuario { get; set; }
        public string identificacion { get; set; }
        public string tipoDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string UniversidadEgreso { get; set; }
        public string fechaFinalizacion { get; set; }
        public string areaEspecializada { get; set; }
        public string areaPsicologo { get; set; }
        public string mesesExperiencia { get; set; }
    }

    public class PsicologoViewModel : PsicologoInputModel
    {
        public PsicologoViewModel(Psicologo psicologo)
        {
            nombreUsuario = psicologo.nombreUsuario;
            contraseña = psicologo.contraseña;
            tipoUsuario = psicologo.tipoUsuario;
            identificacion = psicologo.identificacion;
            tipoDocumento = psicologo.tipoDocumento;
            nombre = psicologo.nombre;
            apellido = psicologo.apellido;
            sexo = psicologo.sexo;
            fechaNacimiento = psicologo.fechaNacimiento;
            telefono = psicologo.telefono;
            direccion = psicologo.direccion;
            correo = psicologo.correo;
            UniversidadEgreso = psicologo.UniversidadEgreso;
            fechaFinalizacion = psicologo.fechaFinalizacion;
            areaEspecializada = psicologo.areaEspecializada;
            areaPsicologo = psicologo.areaPsicologo;
            mesesExperiencia = psicologo.mesesExperiencia;


        }

    }
}
