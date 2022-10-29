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
        [StringLength(16, ErrorMessage = "el nombre de usuario debe tener de 5-16 caracteres", MinimumLength = 5)]
        public string nombreUsuario { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(10, ErrorMessage = "la contraseña debe tener de 8-16 cracteres alfanumericos", MinimumLength = 7)]
        public string contrasena { get; set; }
        public string tipoUsuario { get; set; }
        [Required(ErrorMessage = "El identificacion es requerida")]
        [StringLength(10, ErrorMessage = "la identificacion debe tener de 7-10 digitos", MinimumLength = 7)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string identificacion { get; set; }
        [Required(ErrorMessage = "El tipo documento es requerido")]
        public string tipoDocumento { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(20, ErrorMessage = "el nombre debe tener de 3-20 caracteres", MinimumLength = 3)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerida")]
        [StringLength(20, ErrorMessage = "el apellido debe tener de 3-20 caracteres", MinimumLength = 3)]
        public string apellido { get; set; }
        public string sexo { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "El telefono es requerido")]
        [StringLength(10, ErrorMessage = "el nombre debe tener de 10 datos numericos", MinimumLength = 10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "La direccion es requerida")]
        [StringLength(40, ErrorMessage = "la direccion debe tener como maximos 40 caracteres alfanumericos")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(30, ErrorMessage = "el correo debe tener de 6-30 caracteres", MinimumLength = 6)]
        public string correo { get; set; }
        [Required(ErrorMessage = "La universidad es requerida")]
        [StringLength(30, ErrorMessage = "La universidad debe tener de 6-30 caracteres", MinimumLength = 6)]
        public string UniversidadEgreso { get; set; }
        [Required(ErrorMessage = "La fecha finalizacion es requerida")]
        public string fechaFinalizacion { get; set; }
        [Required(ErrorMessage = "El area especializada es requerida")]
        [StringLength(30, ErrorMessage = "el area especializada debe tener de 6-30 caracteres", MinimumLength = 6)]
        public string areaEspecializada { get; set; }
        [Required(ErrorMessage = "Los meses de experiencia son requeridos")]
        [StringLength(3, ErrorMessage = "debe digitar 3 digitos ejemplo: 001", MinimumLength = 3)]
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
            edad=psicologo.edad;
           UniversidadEgreso=psicologo.UniversidadEgreso;
           fechaFinalizacion=psicologo.fechaFinalizacion;
           areaEspecializada=psicologo.areaEspecializada;
           mesesExperiencia=psicologo.mesesExperiencia;

        }
        public int edad {get; set;}
    }
}
