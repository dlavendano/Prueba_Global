using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class cargo
    {
        [Key]
        public int cargoId { get; set; }
        public string descripcion { get; set; }
        public int salario { get; set; }
    }
}
