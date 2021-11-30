using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class EpsService
    {
        private readonly ConsultorioContext _context;


        public EpsService(ConsultorioContext context)
        {
            _context = context;
        }

        public EpsConsultaResponse Consultar()
        {
            try
            {

                return new EpsConsultaResponse(_context.eps.ToList());

            }
            catch (Exception e)
            {
                return new EpsConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            

        }
        public List<string> consultaEps(){
            List<string> listaEps = new List<string>();
            List<Eps> epses= _context.eps.ToList();
            var almacenar= _context.eps.Select(e=>new {e.Administradora}).Distinct().ToList();
            foreach(var item in epses){
                var nombreEps=item.Administradora;
                listaEps.Add(nombreEps);
            }
            return listaEps;
        }
        public class EpsConsultaResponse
        {
            public List<Eps> Eps { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }
            public EpsConsultaResponse(List<Eps> eps)
            {
                Eps = eps;
                Error = false;
            }
            public EpsConsultaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }
    }
    
}
