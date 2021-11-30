using System;
using System.ComponentModel.DataAnnotations;
using Entidad;
using Proyectopweb;
namespace Proyectopweb.Models
{
    public class PacienteInputModel
    {
        [Required(ErrorMessage = "el nombre de usuario es requerido")] 
        public string nombreUsuario { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string contrasena { get; set; }
        [Required(ErrorMessage = "El tipo de documento es requerido")]
        public string tipoDocumento { get; set; }
        [Required(ErrorMessage = "El identificacion es requerida")]
        public string identificacion { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        public string apellido { get; set; }
        // [SexoValidacion( ErrorMessage="El Sexo de ser F o M")]
        public string sexo { get; set; }
        [Required(ErrorMessage = "El fechaNacimiento es requerida")]
        public DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "El telefono es requerido")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "La direccion es requerida")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
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
            if ((value.ToString().ToUpper() == "M") || (value.ToString().ToUpper() == "F"))
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
            
            
            
        }
    }
}