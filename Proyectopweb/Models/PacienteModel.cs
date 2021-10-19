using Entidad;

namespace Proyectopweb.Models
{
    public class PacienteInputModel
    {
        public string identificacion {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string sexo {get; set;}
        public int edad {get; set;}
        public string telefono {get; set;}
        public string direccion {get; set;}
        public string correo {get; set;}
        public string Eps {get; set;}
    }

    public class PacienteViewModel : PacienteInputModel
    {
        public PacienteViewModel()
        {

        }
        public PacienteViewModel(Paciente paciente)
        {
           identificacion = paciente.identificacion;
           nombre = paciente.nombre;
           apellido = paciente.apellido;
           sexo = paciente.sexo;
           edad = paciente.edad;
           telefono =paciente.telefono;
           direccion =paciente.direccion;
           correo =paciente.correo;
           Eps =paciente.Eps;
        }
        
    }
}