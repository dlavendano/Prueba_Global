using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class empleado
    {
        [Key]
        public int empleadoId { get; set; }
        public string nombre { get; set; }
        public int documento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string genero { get; set; }
        [ForeignKey("cargo")]
        public int cargo { get; set; }
    }
}
