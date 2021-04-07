using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class TeacherControl
    {
        [Key]
        public int TeacherId { get; set; }
        public float Primer_parcial { get; set; }
        public float Segundo_parcial { get; set; }
        public float ProyectoF { get; set; }

        public virtual Estudiantes Estudiante { get; set; }
        public virtual Semestres Semestre { get; set; }
        public virtual Asignaturas Asignatura { get; set; }

    }
}
