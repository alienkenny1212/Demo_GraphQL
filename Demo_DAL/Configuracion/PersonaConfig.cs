using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Demo_Core.Modelos;

namespace Demo_DAL.Configuracion;

public class PersonaConfig : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Personas");
        builder.HasKey(ent => ent.IdPersona);
        builder.Property(i => i.IdPersona)
            .HasColumnName("IdPersona");
        builder.HasMany(ent => ent.Contactos)
           .WithOne(e => e.Individuo)
             .HasForeignKey(e=>e.IdPersona);
    }
}
