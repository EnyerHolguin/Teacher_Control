// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teacher_Control.Data;

namespace Teacher_Control.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210407183616_Migration_Inicial")]
    partial class Migration_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Teacher_Control.Models.Adicionales", b =>
                {
                    b.Property<int>("AdicionalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<double>("Punto")
                        .HasColumnType("float");

                    b.HasKey("AdicionalesId");

                    b.ToTable("Adicionale");
                });

            modelBuilder.Entity("Teacher_Control.Models.Asignaturas", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AsignaturaId");

                    b.ToTable("Asignatura");
                });

            modelBuilder.Entity("Teacher_Control.Models.Asistencia", b =>
                {
                    b.Property<int>("AsistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("A")
                        .HasColumnType("bit");

                    b.Property<int?>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int>("ConteoA")
                        .HasColumnType("int");

                    b.Property<int>("ConteoE")
                        .HasColumnType("int");

                    b.Property<int>("ConteoP")
                        .HasColumnType("int");

                    b.Property<bool>("E")
                        .HasColumnType("bit");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAsistencia")
                        .HasColumnType("datetime2");

                    b.Property<bool>("P")
                        .HasColumnType("bit");

                    b.Property<int?>("SemestreId")
                        .HasColumnType("int");

                    b.HasKey("AsistenciaId");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("SemestreId");

                    b.ToTable("Asistencia");
                });

            modelBuilder.Entity("Teacher_Control.Models.Estudiantes", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("Teacher_Control.Models.Inscripcion", b =>
                {
                    b.Property<int>("IncripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("SemestreId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherControlTeacherId")
                        .HasColumnType("int");

                    b.HasKey("IncripcionId");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("SemestreId");

                    b.HasIndex("TeacherControlTeacherId");

                    b.ToTable("Inscripcions");
                });

            modelBuilder.Entity("Teacher_Control.Models.InscripcionDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int?>("AsistenciaId")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncripcionId")
                        .HasColumnType("int");

                    b.Property<int>("SemestreId")
                        .HasColumnType("int");

                    b.Property<bool>("esta")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("AsistenciaId");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("IncripcionId");

                    b.HasIndex("SemestreId");

                    b.ToTable("InscripcionDetalle");
                });

            modelBuilder.Entity("Teacher_Control.Models.Semestres", b =>
                {
                    b.Property<int>("SemestreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SemestreId");

                    b.ToTable("Semestre");
                });

            modelBuilder.Entity("Teacher_Control.Models.TeacherControl", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<float>("Primer_parcial")
                        .HasColumnType("real");

                    b.Property<float>("ProyectoF")
                        .HasColumnType("real");

                    b.Property<float>("Segundo_parcial")
                        .HasColumnType("real");

                    b.Property<int?>("SemestreId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("SemestreId");

                    b.ToTable("TeacherControl");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Teacher_Control.Models.Asistencia", b =>
                {
                    b.HasOne("Teacher_Control.Models.Asignaturas", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId");

                    b.HasOne("Teacher_Control.Models.Estudiantes", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Control.Models.Semestres", "Semestre")
                        .WithMany()
                        .HasForeignKey("SemestreId");

                    b.Navigation("Asignatura");

                    b.Navigation("Estudiante");

                    b.Navigation("Semestre");
                });

            modelBuilder.Entity("Teacher_Control.Models.Inscripcion", b =>
                {
                    b.HasOne("Teacher_Control.Models.Asignaturas", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Control.Models.Estudiantes", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Control.Models.Semestres", "Semestre")
                        .WithMany()
                        .HasForeignKey("SemestreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Control.Models.TeacherControl", "TeacherControl")
                        .WithMany()
                        .HasForeignKey("TeacherControlTeacherId");

                    b.Navigation("Asignatura");

                    b.Navigation("Estudiante");

                    b.Navigation("Semestre");

                    b.Navigation("TeacherControl");
                });

            modelBuilder.Entity("Teacher_Control.Models.InscripcionDetalle", b =>
                {
                    b.HasOne("Teacher_Control.Models.Asignaturas", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Control.Models.Asistencia", null)
                        .WithMany("InscripcionDetalles")
                        .HasForeignKey("AsistenciaId");

                    b.HasOne("Teacher_Control.Models.Estudiantes", "Estudiante")
                        .WithMany("inscripcionDetalles")
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Control.Models.Inscripcion", null)
                        .WithMany("InscripcionDetalles")
                        .HasForeignKey("IncripcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teacher_Control.Models.Semestres", "Semestre")
                        .WithMany()
                        .HasForeignKey("SemestreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asignatura");

                    b.Navigation("Estudiante");

                    b.Navigation("Semestre");
                });

            modelBuilder.Entity("Teacher_Control.Models.TeacherControl", b =>
                {
                    b.HasOne("Teacher_Control.Models.Asignaturas", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId");

                    b.HasOne("Teacher_Control.Models.Estudiantes", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId");

                    b.HasOne("Teacher_Control.Models.Semestres", "Semestre")
                        .WithMany()
                        .HasForeignKey("SemestreId");

                    b.Navigation("Asignatura");

                    b.Navigation("Estudiante");

                    b.Navigation("Semestre");
                });

            modelBuilder.Entity("Teacher_Control.Models.Asistencia", b =>
                {
                    b.Navigation("InscripcionDetalles");
                });

            modelBuilder.Entity("Teacher_Control.Models.Estudiantes", b =>
                {
                    b.Navigation("inscripcionDetalles");
                });

            modelBuilder.Entity("Teacher_Control.Models.Inscripcion", b =>
                {
                    b.Navigation("InscripcionDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
