using System;
using System.ComponentModel.DataAnnotations;
using Entidad;
using Proyectopweb;

namespace Proyectopweb.Models
{
    public class PacienteInputModel
    {
        [Required(ErrorMessage = "el nombre de usuario es requerido")]
        [StringLength(16,ErrorMessage ="el nombre de usuario debe tener minimo 5 caracteres y maximo 20", MinimumLength = 5)]
        public string nombreUsuario { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(16, ErrorMessage = "La contraseña debe tener minimo 8 caracteres y maximo 16", MinimumLength = 8)]
        public string contrasena { get; set; }
        [Required(ErrorMessage = "El tipo de documento es requerido")]
        public string tipoDocumento { get; set; }
        [Required(ErrorMessage = "El identificacion es requerida")]
        [StringLength(10, ErrorMessage = "La identificacion debe tener minimo 7 digitos y maximo 10", MinimumLength = 7)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string identificacion { get; set; }
        
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(20, ErrorMessage = "el nombre debe tener minimo 3 caracteres y maximo 20", MinimumLength = 3)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(20, ErrorMessage = "el apellido debe tener minimo 3 caracteres y maximo 20", MinimumLength = 3)]
        public string apellido { get; set; }

        
        public string sexo { get; set; }
        [Required(ErrorMessage = "La fecha de Nacimiento es requerida")]
        public DateTime fechaNacimiento { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        [StringLength(10, ErrorMessage = "La direccion debe tener 10 digitos", MinimumLength = 10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "La direccion es requerida")]
        [StringLength(40, ErrorMessage ="debe tener como maximo 20 campos alfanumericos")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(30, ErrorMessage = "El correo debe tener minimo 8 caracteres alfanumericos y maximo 30", MinimumLength = 8)]
        public string correo { get; set; }
        [Required(ErrorMessage = "La Eps es requerida")]
        public string Eps { get; set; }
        public Usuario usuario { get; set; }
        public string tipoUsuario { get; set; }
        public string estado { get; set; }
        
    } 
    public class SexoValidacion : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((value.ToString().ToUpper() == "Masculino") || (value.ToString().ToUpper() == "Femenino"))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
    public class PacienteViewModel : PacienteInputModel
    {
        public PacienteViewModel()
        {

        }
        public PacienteViewModel(Paciente paciente)
        {
            
            tipoDocumento = paciente.tipoDocumento;
            identificacion = paciente.identificacion;
            nombre = paciente.nombre;
            apellido = paciente.apellido;
            sexo = paciente.sexo;
            fechaNacimiento = paciente.fechaNacimiento;
            direccion = paciente.direccion;
            Eps = paciente.Eps;
            edad=paciente.edad;
            
            
            
        }
        public int edad { get; set; }
    }
}