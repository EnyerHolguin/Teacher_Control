using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class Inscripcion
    {
        [Key]
        public int IncripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public int SemestreId { get; set; }
        public int AignaturaId { get; set; }
        public int EstudianteId { get; set; }
}
}
