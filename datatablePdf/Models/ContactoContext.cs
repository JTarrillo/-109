using Microsoft.EntityFrameworkCore;

namespace DatatableNetCore.Models
{
    public class ContactoContext : DbContext
    {
        public ContactoContext(DbContextOptions<ContactoContext> options) : base(options)
        {
        }
        public DbSet<Contacto> Contactos { get; set; }
    }
}
