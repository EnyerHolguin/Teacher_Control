using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class Semestres
    {
        [Key]
        public int SemestreId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una Descripcion .")]
        public string Descripcion { get; set; }
    }
}
