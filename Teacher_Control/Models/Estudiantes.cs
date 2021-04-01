using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir un nombres.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir un Apellidos.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir un número telefónico .")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir un Email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public int Matricula { get; set; }
        //public {get; set;}

        [ForeignKey("EstudianteId")]
        public virtual List<InscripcionDetalle> inscripcionDetalles { get; set; } = new List<InscripcionDetalle>();

        public Estudiantes()
        {
            this.FechaNacimiento = DateTime.Now;
        }
    }
}
