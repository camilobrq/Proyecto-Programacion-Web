using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entidad;

namespace Proyectopweb.Models
{
    public class PsicologoInputModel
    {
        [Required(ErrorMessage = "el nombre de usuario es requerido")] 
        public string nombreUsuario { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string contrasena { get; set; }
        public string tipoUsuario { get; set; }
        [Required(ErrorMessage = "El identificacion es requerida")]
        public string identificacion { get; set; }
        [Required(ErrorMessage = "El tipo documento es requerido")]
        public string tipoDocumento { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerida")]
        public string apellido { get; set; }
        public string sexo { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "El telefono es requerido")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "La direccion es requerida")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        public string correo { get; set; }
        [Required(ErrorMessage = "La universidad es requerida")]
        public string UniversidadEgreso { get; set; }
        [Required(ErrorMessage = "La fecha finalizacion es requerida")]
        public string fechaFinalizacion { get; set; }
        [Required(ErrorMessage = "El area especializada es requerida")]
        public string areaEspecializada { get; set; }
        [Required(ErrorMessage = "Los meses de experiencia son requeridos")]
        public string mesesExperiencia { get; set; }
        public Usuario usuario { get; set; }
    }

    public class PsicologoViewModel : PsicologoInputModel
    {
        public PsicologoViewModel(Psicologo psicologo)
        {
            
            identificacion = psicologo.identificacion;
           nombre = psicologo.nombre;
           apellido = psicologo.apellido;
           sexo = psicologo.sexo;
           
           direccion =psicologo.direccion;
          
           UniversidadEgreso=psicologo.UniversidadEgreso;
           fechaFinalizacion=psicologo.fechaFinalizacion;
           areaEspecializada=psicologo.areaEspecializada;
           mesesExperiencia=psicologo.mesesExperiencia;

        }
        public int edad {get; set;}
    }
}
