using Entidad;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class TerceroContext : DbContext
    {
        public TerceroContext(DbContextOptions options) : base(options) { }
        public DbSet<Tercero> Terceros { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}