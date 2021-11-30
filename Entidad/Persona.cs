using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Persona
    {

        [Key]
        public string identificacion {get; set;}
 
   
        public string tipoDocumento { get; set; }
 
    
        public string nombre {get; set;}

       
        public string apellido {get; set;}

        
        public string sexo {get; set;}
        public DateTime fechaNacimiento { get; set; }
       
        public int edad { get; set; }
        public string direccion {get; set;}
        
         public int calcularEdad(DateTime fechaNacimiento){
            
            edad=DateTime.Today.Year-fechaNacimiento.Year;
            if(DateTime.Today.Year<=fechaNacimiento.Year){

                return -1;
            }else{     
                return edad;
            }
        }
       
        

        
    }
}
