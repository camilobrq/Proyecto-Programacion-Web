using System;
using System.ComponentModel.DataAnnotations;
using Entidad;

namespace Proyectopweb.Models
{
    public class EvaluacionInputModel
    {
        [Required(ErrorMessage ="debe llenar el campo de identificacion")]
        [StringLength(10, ErrorMessage = "la identificacion debe tener de 7-10 digitos", MinimumLength = 7)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string identificacionPaciente {get; set;}
        [Required(ErrorMessage = "debe llenar el campo de identificacion")]
        [StringLength(10, ErrorMessage = "la identificacion debe tener de 7-10 digitos", MinimumLength = 7)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string identificacionPsicologo {get; set;}
        [Required(ErrorMessage = "debe llenar el campo de diagnostico")]
        [StringLength(200, ErrorMessage = "numero maximo de caracteres es de 200")]
        public string diagnostico {get; set;}
        [Required(ErrorMessage = "debe llenar el campo de ocupacion")]
        [StringLength(20, ErrorMessage = "numero maximo de caracteres es de 20")]
        public string ocupacion { get; set; }
        [Required(ErrorMessage = "debe llenar el campo de consulta")]
        [StringLength(50, ErrorMessage = "numero maximo de caracteres es de 50")]
        public string consulta { get; set; }
        [Required(ErrorMessage = "debe llenar el campo de observacion")]
        [StringLength(50, ErrorMessage = "numero maximo de caracteres es de 50")]
        public string observacion { get; set; }
        public string prueba { get; set; }
        [Required(ErrorMessage = "debe llenar el campo de analisis")]
        [StringLength(50, ErrorMessage = "numero maximo de caracteres es de 50")]
        public string analisis { get; set; }
        [Required(ErrorMessage = "debe llenar el campo de pronostico")]
        [StringLength(50, ErrorMessage = "numero maximo de caracteres es de 50")]
        public string pronostico { get; set; }
        [Required(ErrorMessage = "debe llenar el campo de recomendacion")]
        [StringLength(200, ErrorMessage = "numero maximo de caracteres es de 200")]
        public string recomendacion { get; set; }

    }

    public class EvaluacionViewModel : EvaluacionInputModel
    {

        public EvaluacionViewModel()
        {

        }
        public EvaluacionViewModel(Evaluacion evaluacion)
        {
            IdEvaluacion = evaluacion.IdEvaluacion;
            identificacionPaciente = evaluacion.identificacionPaciente;
            identificacionPsicologo = evaluacion.identificacionPsicologo;
            diagnostico = evaluacion.diagnostico;
            ocupacion = evaluacion.ocupacion;
            consulta = evaluacion.consulta;
            observacion = evaluacion.observacion;
            prueba = evaluacion.prueba;
            analisis = evaluacion.analisis;
            pronostico = evaluacion.pronostico;
            recomendacion = evaluacion.recomendacion;
        }
        public int IdEvaluacion { get; set; }
    }
}