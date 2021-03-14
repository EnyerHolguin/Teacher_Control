using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Control.Models
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Descripcion { get; set; }
    }
}
