using System;
using System.ComponentModel.DataAnnotations;
using Entidad;
using Proyectopweb;
namespace Proyectopweb.Models
{
    public class EpsInputModel
    {
       
 

    }
    
    public class EpsViewModel : EpsInputModel
    {
        public EpsViewModel()
        {

        }
        public EpsViewModel(Eps eps)
        {
            Administradora=eps.Administradora;
           

        }
         public string Administradora { get; set; }
        
    }
}