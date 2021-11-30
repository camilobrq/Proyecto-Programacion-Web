using System;
using Entidad;

namespace Proyectopweb.Models
{
    public class TratamientoInputModel
    {
        public string identificacionPaciente { get; set; }
        public string identificacionPsicologo { get; set; }
        public DateTime fecha { get; set; }

        public string codigo_3 { get; set; }
        public string codigo_4 { get; set; }
        public string descripcion_3 { get; set; }
        public string descripcion_4 { get; set; }
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
            codigo_3= tratamiento.codigo_3;
            codigo_4=tratamiento.codigo_4;
            descripcion_3=tratamiento.descripcion_3;
            descripcion_4=tratamiento.descripcion_4;
            fecha = tratamiento.fecha;
            medicacion = tratamiento.medicacion;
            tratamientoPaso = tratamiento.tratamientoPaso;

        }
        public int IdTratamiento { get; set; }
    }
}