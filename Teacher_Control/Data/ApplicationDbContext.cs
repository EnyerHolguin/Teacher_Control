using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Teacher_Control.Models;


namespace Teacher_Control.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignaturas> Asignatura { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Estudiantes> Estudiante { get; set; }
        public virtual DbSet<Inscripcion> Inscripcions { get; set; }
        public virtual DbSet<Semestres> Semestre { get; set; }
        public virtual DbSet<Adicionales> Adicionale { get; set; }
        public virtual DbSet<TeacherControl> TeacherControl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            /*if (!optionsBuilder.IsConfigured)
            {

               // optionsBuilder.UseSqlServer("Server=proyectofinalap2.database.windows.net;Database=Teacher_control;User ID=Teacher_Control;Password=intern@Aplicada2;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }*/
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignaturas>().HasData(new Asignaturas() { AsignaturaId = 1, Descripcion = "Aplicada I" });
            modelBuilder.Entity<Asignaturas>().HasData(new Asignaturas() { AsignaturaId = 2, Descripcion = "Aplicada II" });
        }*/

    }
}
