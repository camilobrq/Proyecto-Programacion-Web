using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class TratamientoInputModel
    {
        public int idTratamiento { get; set; }
        public string nombreTratamiento { get; set; }
        public string descripcionTratamiento { get; set; }

    }


    public class TratamientoViewModel : TratamientoInputModel
    {
        public TratamientoViewModel(Tratamiento tratamiento)
        {
            idTratamiento = tratamiento.idTratamiento;
            nombreTratamiento = tratamiento.nombreTratamiento;
            descripcionTratamiento = tratamiento.descripcionTratamiento;



        }

    }
}
