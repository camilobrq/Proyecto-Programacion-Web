using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class EnfermedadInputModel
    {



    }

    public class EnfermedadViewModel : EnfermedadInputModel
    {

        public EnfermedadViewModel()
        {

        }
        public EnfermedadViewModel(Enfermedad enfermedad)
        {
            idEnfermedad = enfermedad.idEnfermedad;
            Codigo_3 = enfermedad.Codigo_3;
            Descripcion_3 = enfermedad.Descripcion_3;
            Codigo_4 = enfermedad.Codigo_4;
            Descripcion_4 = enfermedad.Descripcion_4;

        }
        public int idEnfermedad { get; set; }
        public string Codigo_3 { get; set; }
        public string Descripcion_3 { get; set; }
        public string Codigo_4 { get; set; }
        public string Descripcion_4 { get; set; }
    }

}