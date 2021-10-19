using Microsoft.EntityFrameworkCore;
using Entidad;
namespace Datos
{
    public class ConsultorioContext:DbContext
    {
         public ConsultorioContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Cita> citas { get; set; }

    }
}
