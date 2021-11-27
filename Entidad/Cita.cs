
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entidad
{
    public class Cita
    {
        [Key]
        public int idCita{get; set; }
        public string fecha { get; set; }

        public string hora { get; set; }

        public Paciente paciente { get; set; }

        public Psicologo psicologo { get; set; }

        public Diagnostico diagnostico { get; set; }
        

        public void obtenerFechaHora(string fecha, string hora)
        {
            this.fecha = fecha;
            this.hora = hora;
        }
        
    }
}
