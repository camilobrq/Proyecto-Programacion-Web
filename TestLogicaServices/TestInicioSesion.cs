using Datos;
using Logica;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestLogicaServices
{
    public class TestInicioSesion
    {

        private UsuarioService service;

        string stringConnections = "Server=HP245-G7\\SQLEXPRESS;Database=ConsultorioPsicologico;Trusted_Connection = True; MultipleActiveResultSets = true";

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ConsultorioContext>().UseSqlServer(stringConnections).Options;
            ConsultorioContext Db = new ConsultorioContext(contextOptions);
            service = new UsuarioService(Db);
        }
        [Test]
        public void ValidadUsuario()
        {
            var respuesta = service.Validate("camilo", "123");
            Assert.IsNotNull(respuesta);
        }
    }
}