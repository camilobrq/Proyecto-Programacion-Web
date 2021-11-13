using System;
using System.ComponentModel.DataAnnotations;
using Entidad;
using Proyectopweb;
namespace Proyectopweb.Models
{
    public class PacienteInputModel
    {
          [Required(ErrorMessage = "La identificacion es requerida")]
        public string tipoDocumento { get; set; }
        [Required(ErrorMessage = "El identificacion es requerida")]
        public string identificacion {get; set;}
        [Required(ErrorMessage = "El nombre es requerida")]
        public string nombre {get; set;}
        [Required(ErrorMessage = "El apellido es requerida")]
        public string apellido {get; set;}
       // [SexoValidacion( ErrorMessage="El Sexo de ser F o M")]
        public string sexo {get; set;}
        [Required(ErrorMessage = "El fechaNacimiento es requerida")]
        public DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "El telefono es requerida")]
        public string telefono {get; set;}
        [Required(ErrorMessage = "El direccion es requerida")]
        public string direccion {get; set;}
        [Required(ErrorMessage = "El correo es requerida")]
        public string correo {get; set;}
        [Required(ErrorMessage = "El Eps es requerida")]
        public string Eps {get; set;}
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
            tipoDocumento=paciente.tipoDocumento;
           identificacion = paciente.identificacion;
           nombre = paciente.nombre;
           apellido = paciente.apellido;
           sexo = paciente.sexo;
           fechaNacimiento=paciente.fechaNacimiento;
           edad = paciente.edad;
           telefono =paciente.telefono;
           direccion =paciente.direccion;
           correo =paciente.correo;
           Eps =paciente.Eps;
        }
        public int edad {get; set;}
    }
}