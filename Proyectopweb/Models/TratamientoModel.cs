using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class TratamientoInputModel
    {
        public string identificacionPaciente { get; set; }
        public string identificacionPsicologo { get; set; }
        public DateTime fecha { get; set; }
        public string medicacion { get; set; }
        public string tratamientoPaso { get; set; }

    }

    public class TratamientoViewModel : TratamientoInputModel
    {

        public TratamientoViewModel()
        {

        }
        public TratamientoViewModel(Tratamiento tratamiento)
        {
            IdTratamiento = tratamiento.IdTratamiento;
            identificacionPaciente = tratamiento.identificacionPaciente;
            identificacionPsicologo = tratamiento.identificacionPsicologo;
            fecha = tratamiento.fecha;
            medicacion = tratamiento.medicacion;
            tratamientoPaso = tratamiento.tratamientoPaso;

        }
        public int IdTratamiento { get; set; }
    }
}