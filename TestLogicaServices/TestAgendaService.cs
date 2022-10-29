using Datos;
using Entidad;
using Logica;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestLogicaServices
{
    public class TestAgendaService
    {
        private AgendaService service;

        string stringConnections = "Server=HP245-G7\\SQLEXPRESS;Database=ConsultorioPsicologico;Trusted_Connection = True; MultipleActiveResultSets = true";

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ConsultorioContext>().UseSqlServer(stringConnections).Options;
            ConsultorioContext Db = new ConsultorioContext(contextOptions);
            service = new AgendaService(Db);
        }
        
        [Test]
        public void TestGuardarAgenda()
        {
            Agenda agenda = new Agenda()
            {
                idPsicologo = "1",
                fechaDeseada = new System.DateTime(06 / 08 / 2022),
                horaCita = "8:00 a.m - 12:00 a.m",
                psicologo = new Psicologo
                {
                    identificacion = "1",

                }
            };

            var respuesta = service.Guardar(agenda);
            Assert.IsNotNull(respuesta.Agenda);
        }
        [Test]
        public void TestGuardarAgenda1()
        {
            Agenda agenda = new Agenda()
            {

                idPsicologo = "12",
                fechaDeseada = new System.DateTime(06 / 08 / 2022),
                horaCita = "8:00 a.m - 12:00 a.m",
                psicologo = new Psicologo
                {
                    identificacion = "12",

                }


            };

            var respuesta = service.Guardar(agenda);
            Assert.IsNull(respuesta.Agenda);
        }

        [Test]
        public void TestListaAgenda()
        {
            var respuesta = service.Consultar();
            Assert.IsFalse(respuesta.Error);
        }

        [Test]
        public void TestBuscarPsicologo()
        {
            var respuesta = service.buscarPsicologo("1");
            
        }



    }
}