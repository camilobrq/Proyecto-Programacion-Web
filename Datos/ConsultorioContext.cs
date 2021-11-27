﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidad;

namespace Datos
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Psicologo> psicologos { get; set; }
        public DbSet<Administrador> administradores { get; set; }
        public DbSet<Agenda> agendas { get; set; }
        public DbSet<Cita> citas { get; set; }
        public DbSet<Diagnostico> diagnosticos { get; set; }
        public DbSet<Disponibilidad> disponibilidades { get; set; }
        public DbSet<Tratamiento> tratamientos { get; set; }
    }

}

