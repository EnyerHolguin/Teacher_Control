using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class Inscripcion
    {
        [Key]
        public int IncripcionId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int SemestreId { get; set; }
        public int AsignaturaId { get; set; }
        public int EstudianteId { get; set; }

        [ForeignKey("IncripcionId")]
        public virtual List<InscripcionDetalle> InscripcionDetalles { get; set; } = new List<InscripcionDetalle>();

        public Inscripcion()
        {
            this.Fecha = DateTime.Now;
        }
    }
}
