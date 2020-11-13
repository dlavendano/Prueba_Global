using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<cargo> cargo {get; set;}
        public DbSet<empleado> empleado { get; set; }
        public DbSet<tienda> tienda { get; set; }
        public DbSet<tiendaEmpleado> tiendaEmpleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tiendaEmpleado>().HasKey(u => new
            {
                u.empleadoId,
                u.tiendaId
            });
        }
    }
}
