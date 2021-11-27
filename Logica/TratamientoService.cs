using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class TratamientoService
    {
        private readonly ConsultorioContext _context;


        public TratamientoService(ConsultorioContext context)
        {
            _context = context;
        }

        public GuardarTratamientoResponse Guardar(Tratamiento tratamiento)
        {
            try
            {
                var TratamientoBuscadoidTratamiento = _context.tratamientos.Find(tratamiento.idTratamiento);
                if (TratamientoBuscadoidTratamiento != null)
                {
                    return new GuardarTratamientoResponse("Error, ya existe un tratamiento con este id");
                }
                _context.tratamientos.Add(tratamiento);
                _context.SaveChanges();
                return new GuardarTratamientoResponse(tratamiento);
            }
            catch (Exception e)
            {
                return new GuardarTratamientoResponse($"Error de la aplicacion: {e.Message}");
            }
        }

        public List<Tratamiento> ConsultarTodosLosTratamientos()
        {
            List<Tratamiento> tratamientos = _context.tratamientos.ToList();
            return tratamientos;
        }
    }


    public class GuardarTratamientoResponse
    {
        public GuardarTratamientoResponse(Tratamiento tratamiento)
        {
            Error = false;
            this.tratamiento = tratamiento;
        }
        public GuardarTratamientoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Tratamiento tratamiento { get; set; }

    }
}

