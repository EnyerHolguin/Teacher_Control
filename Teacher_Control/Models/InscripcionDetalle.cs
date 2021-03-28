using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class InscripcionDetalle
    {
        [Key]
        public int Id { get; set; }
        public int IncripcionId { get; set; } 
        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }
        public int SemestreId { get; set; }
    }
}