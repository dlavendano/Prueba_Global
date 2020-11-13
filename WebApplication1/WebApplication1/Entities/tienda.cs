using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class tienda
    {
        public tienda()
        {
            this.tiendaEmpleado = new HashSet<tiendaEmpleado>();
        }
        [Key]
        public int tiendaId { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public virtual ICollection<tiendaEmpleado> tiendaEmpleado { get; set; }
    }
}
