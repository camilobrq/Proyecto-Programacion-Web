using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class PsicologoInputModel
    {
      public string tipoDocumento { get; set; }
        public string identificacion {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string sexo {get; set;}
       
        public string telefono {get; set;}
        public string direccion {get; set;}
        public string correo {get; set;}
        public string Universidad {get; set;}
        public string areaEspecializada { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string fechaFinalizacion {get; set;}
      //  public byte[] certificado { get; set; }
        public string mesesExperiencia {get; set;}
    }

    public class PsicologoViewModel : PsicologoInputModel
    {
        public PsicologoViewModel()
        {

        }
        public PsicologoViewModel(Psicologo psicologo)
        {
           identificacion = psicologo.identificacion;
           nombre = psicologo.nombre;
           apellido = psicologo.apellido;
           sexo = psicologo.sexo;
           telefono =psicologo.telefono;
           direccion =psicologo.direccion;
           correo =psicologo.correo;
           Universidad=psicologo.Universidad;
           fechaFinalizacion=psicologo.fechaFinalizacion;
           areaEspecializada=psicologo.areaEspecializada;
           mesesExperiencia=psicologo.mesesExperiencia;
        }
        public int edad {get; set;}
    }
}