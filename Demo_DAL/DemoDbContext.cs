using Demo_Core.Modelos;
using Demo_DAL.Configuracion;
using Microsoft.EntityFrameworkCore;

namespace Demo_DAL;

public class DemoDbContext : DbContext
{
    public DemoDbContext(DbContextOptions options)
    : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new PersonaConfig());
        builder.ApplyConfiguration(new ContactoConfig());
        //builder.ApplyConfiguration(new TenantWebConfig());
    }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Contacto> Contactos { get; set; }
}
