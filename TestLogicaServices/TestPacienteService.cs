using Datos;
using Entidad;
using Logica;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestLogicaServices
{
    public class TestPacienteService
    {
        private PacienteService service;

        string stringConnections = "Server=HP245-G7\\SQLEXPRESS;Database=ConsultorioPsicologico;Trusted_Connection = True; MultipleActiveResultSets = true";

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ConsultorioContext>().UseSqlServer(stringConnections).Options;
            ConsultorioContext Db = new ConsultorioContext(contextOptions);
            service = new PacienteService(Db);
        }
        
        [Test]
        public void TestGuardarPaciente()
        {

            Paciente paciente = new Paciente()
            {
                nombre = "antonio",
                apellido="fernandez",
                direccion="mz 13 mayales",
                tipoDocumento="CC",
                sexo="Masculino",
                identificacion="12345",
                fechaNacimiento=new System.DateTime(16/01/2001),
               

            };
            var respuesta=service.Guardar(paciente);
            Assert.IsNotNull(respuesta.Paciente);
        }
        [Test]
        public void TestGuardarPacienteFallido()
        {

            Paciente paciente = new Paciente()
            {
                nombre = "antonio",
                apellido = "fernandez",
                direccion = "mz 13 mayales",
                tipoDocumento = "CC",
                sexo = "Masculino",
                identificacion = "123455666",
                fechaNacimiento = new System.DateTime(16 / 01 / 2001),


            };
            var respuesta = service.Guardar(paciente);
            Assert.AreEqual(respuesta.Mensaje, "Error, el paciente ya esta registrado o el nombre de usuario no esta Disponible.");
        }
        [Test]
        public void TestListaPaciente()
        {
            var respuesta = service.ConsultarTodosLosPacientes();
            Assert.IsFalse(respuesta.Error);
        }
       

        [Test]
        public void TestBuscarPaciente()
        {
            var respuesta = service.Buscar("1825");
            Assert.IsNotNull(respuesta.Paciente);
        }

        [Test]
        public void TestBuscarPacienteNull()
        {
            var respuesta = service.Buscar("18251111");
            Assert.IsNull(respuesta.Paciente);
        }

        
        [Test]
        public void TestEliminarPaciente()
        {
            var respuesta = service.Eliminar("camil01");
            Assert.IsNotNull(respuesta);
        }
        
        [Test]
        public void TestEliminarPacienteNull()
        {
            var respuesta = service.Eliminar("carlosss");
            Assert.AreEqual(respuesta, "No fue posible eliminar el registro, porque no existe el paciente con el nombre de usuario: carlosss");
        }

    }
}