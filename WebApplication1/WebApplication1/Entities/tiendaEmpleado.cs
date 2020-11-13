using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class tiendaEmpleado
    {
        [Key]
        public int empleadoId { get; set; }
        [Key]
        public int tiendaId { get; set; }
        public DateTime fecha { get; set; }
        public virtual empleado empleados { get; set; }
        public virtual tienda tiendas { get; set; }
    }
}
