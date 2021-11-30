using Datos;
using Entidad;
using System;
using System.Linq;
using System.Collections.Generic;
//using SpreadsheetLight;


namespace Logica
{
    public class EnfermedadService
    {
        private readonly ConsultorioContext _context;

        public EnfermedadService(ConsultorioContext context)
        {
            _context = context;
        }
       
        public EnfermedadConsultaResponse Consultar()
        {
            try
            {

                return new EnfermedadConsultaResponse(_context.enfermedades.ToList());

            }
            catch (Exception e)
            {
                return new EnfermedadConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            
        }

        public List<string> ListaCodigo3(){
            List<Enfermedad> enfermedads=_context.enfermedades.ToList();
            List<string> codigo3= new List<string>();
            
                var almacenar= _context.enfermedades.Select(e=>new {e.Codigo_3}).Distinct().ToList();
            foreach(var item in almacenar){
                if(item.Codigo_3!=null ){
                    var almacenar1=item.Codigo_3;
                    codigo3.Add(almacenar1);
                }
            }
            return codigo3;
        }
      
        public List<string> ListaDescripcion3(string codigo3){
            List<Enfermedad> enfermedads=_context.enfermedades.ToList();
            List<string> descripcion3= new List<string>();
            foreach(var item in enfermedads){
                if(item.Codigo_3==codigo3 && item.Descripcion_3!=null){
                    var almacenar=item.Descripcion_3;
                    descripcion3.Add(almacenar);
                }
            }
            return descripcion3;
        }
         public List<string> ListaCodigo4(string codigo3){
            List<Enfermedad> enfermedads=_context.enfermedades.ToList();
            List<string> codigo4= new List<string>();
            foreach(var item in enfermedads){
                if(item.Codigo_3==codigo3){
                    var almacenar=item.Codigo_4;
                   codigo4.Add(almacenar);
                }
            }
            return codigo4;
        }
        public List<string> ListaDescripcion4(string codigo4){
            List<Enfermedad> enfermedads=_context.enfermedades.ToList();
            List<string> descripcion4= new List<string>();
            foreach(var item in enfermedads){
                if(item.Codigo_4==codigo4 ){
                    var almacenar=item.Descripcion_4;
                    descripcion4.Add(almacenar);
                }
            }
            return descripcion4;
        }
       
    }
    public class EnfermedadConsultaResponse
    {
        public List<Enfermedad> Enfermedades { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public EnfermedadConsultaResponse(List<Enfermedad> enfermedades)
        {
            Enfermedades = enfermedades;
            Error = false;
        }
        public EnfermedadConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}