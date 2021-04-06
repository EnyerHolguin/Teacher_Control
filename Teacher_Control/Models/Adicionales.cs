using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class Adicionales
    {
        [Key]
        public int AdicionalesId { get; set; }
        public int EstudianteId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una Descripcion .")]
        public string Descripcion { get; set; }
        public double Punto { get; set; }


    }
}
