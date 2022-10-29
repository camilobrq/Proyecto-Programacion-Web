using Datos;
using Entidad;
using Logica;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestLogicaServices
{
    public class TestPsicologoService
    {
        private PsicologoService service;

        string stringConnections = "Server=HP245-G7\\SQLEXPRESS;Database=ConsultorioPsicologico;Trusted_Connection = True; MultipleActiveResultSets = true";

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ConsultorioContext>().UseSqlServer(stringConnections).Options;
            ConsultorioContext Db = new ConsultorioContext(contextOptions);
            service = new PsicologoService(Db);
        }

        [Test]
        public void TestGuardarPsicologoe()
        {

            Psicologo psicologo = new Psicologo()
            {
                nombre = "antonio",
                apellido = "fernandez",
                direccion = "mz 13 mayales",
                tipoDocumento = "CC",
                sexo = "Masculino",
                identificacion = "1234577",
                fechaNacimiento = new System.DateTime(16 / 01 / 2001),
                areaEspecializada="psicologia interna",

                fechaFinalizacion="16 / 01 / 2001",
                mesesExperiencia="009",
                UniversidadEgreso="Upc"


            };
            var respuesta = service.Guardar(psicologo);
            Assert.IsNotNull(respuesta.psicologo);
        }

        [Test]
        public void TestGuardarPsicologoFallido()
        {

            Psicologo psicologo = new Psicologo()
            {
                nombre = "antonio",
                apellido = "fernandez",
                direccion = "mz 13 mayales",
                tipoDocumento = "CC",
                sexo = "Masculino",
                identificacion = "12345",
                fechaNacimiento = new System.DateTime(16 / 01 / 2001),
                areaEspecializada = "psicologia interna",

                fechaFinalizacion = "16 / 01 / 2001",
                mesesExperiencia = "009",
                UniversidadEgreso = "Upc"


            };
            var respuesta = service.Guardar(psicologo);
            Assert.AreEqual(respuesta.Mensaje, "Error, ya existe un psicologo registrado con el nombre de usuario o el psicologo ya esta registrado");
        }
    }
}