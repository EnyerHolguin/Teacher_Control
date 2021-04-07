using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class Asistencia
    {
        [Key]
        public int AsistenciaId { get; set; }
        public int EstudianteId { get; set; }
        public DateTime FechaAsistencia { get; set; }
        public int ConteoA { get; set; }
        public int ConteoP { get; set; }
        public int ConteoE { get; set; }
        public bool A { get; set; }
        public bool P { get; set; }
        public bool E { get; set; }
        public virtual Estudiantes Estudiante { get; set; }
        public virtual Semestres Semestre { get; set; }
        public virtual Asignaturas Asignatura { get; set; }

        [ForeignKey("AsistenciaId")]
        public virtual List<InscripcionDetalle> InscripcionDetalles { get; set; } = new List<InscripcionDetalle>();

        public Asistencia()
        {
            this.FechaAsistencia = DateTime.Now;
        }
    }
}
