using Datos;
using Entidad;
using Logica;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestLogicaServices
{
    public class TestEvaluacion
    {
        private EvaluacionService service;

        string stringConnections = "Server=HP245-G7\\SQLEXPRESS;Database=ConsultorioPsicologico;Trusted_Connection = True; MultipleActiveResultSets = true";

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ConsultorioContext>().UseSqlServer(stringConnections).Options;
            ConsultorioContext Db = new ConsultorioContext(contextOptions);
            service = new EvaluacionService(Db);
        }

        [Test]
        public void TestGuardarEvaluacion()
        {
            Evaluacion evaluacion = new Evaluacion()
            {
                identificacionPaciente = "1082886086",
                identificacionPsicologo = "1235",
                diagnostico = "holisss",
                ocupacion = "holisss",
                consulta = "holisss",
                observacion = "holisss",
                prueba = "holisss",
                analisis = "holisss",
                pronostico = "holisss",
                recomendacion = "holisss",
                paciente = new Paciente
                {
                    identificacion = "1082886086",

                },
                Psicologo = new Psicologo
                {
                    identificacion = "1235",

                },
            };
            var respusta = service.Guardar(evaluacion);
            Assert.IsNotNull(respusta.Evaluacion);

        }
        [Test]
        public void TestGuardarEvaluacionNull()
        {
            Evaluacion evaluacion = new Evaluacion()
            {
                identificacionPaciente = "22",
                identificacionPsicologo = "1222235",
                diagnostico = "holisss",
                ocupacion = "holisss",
                consulta = "holisss",
                observacion = "holisss",
                prueba = "holisss",
                analisis = "holisss",
                pronostico = "holisss",
                recomendacion = "holisss",
                paciente = new Paciente
                {
                    identificacion = "22",

                },
                Psicologo = new Psicologo
                {
                    identificacion = "1222235",

                },
            };
            var respusta = service.Guardar(evaluacion);
            Assert.IsNull(respusta.Evaluacion);

        }
    }
}