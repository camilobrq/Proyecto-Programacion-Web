using Datos;
using Entidad;
using Logica;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestLogicaServices
{
    public class TestCitaService
    {

        private CitaService service;

        string stringConnections = "Server=HP245-G7\\SQLEXPRESS;Database=ConsultorioPsicologico;Trusted_Connection = True; MultipleActiveResultSets = true";

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ConsultorioContext>().UseSqlServer(stringConnections).Options;
            ConsultorioContext Db = new ConsultorioContext(contextOptions);
            service = new CitaService(Db);
        }
        [Test]
        public void GuardarCita()
        {
            Cita cita = new Cita() {
                idPaciente = "122",
                fechaDeseada = new System.DateTime(2021 - 12 - 16),
                horaCita= "6:00 A.m - 8:00 A.m",
                paciente = new Paciente
                {
                    identificacion = "122",

                },

            };
            var respuesta = service.Guardar(cita);
            Assert.IsNotNull(respuesta.Cita);
        }
         [Test]
        public void GuardarCitaNull()
        {
            Cita cita = new Cita() {
                idPaciente = "12222",
                fechaDeseada = new System.DateTime(2021 - 12 - 16),
                horaCita= "6:00 A.m - 8:00 A.m",
                paciente = new Paciente
                {
                    identificacion = "12222",

                },

            };
            var respuesta = service.Guardar(cita);
            Assert.IsNull(respuesta.Cita);
        }
        
    }
}