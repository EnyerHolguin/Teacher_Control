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
        public string Descripcion { get; set; }
    }
}
