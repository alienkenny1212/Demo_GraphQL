using Demo_Core.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_DAL.Configuracion;

internal class ContactoConfig : IEntityTypeConfiguration<Contacto>
{
    public void Configure(EntityTypeBuilder<Contacto> builder)
    {
        builder.ToTable("ContactosPersonas");
        builder.HasKey(ent => ent.IdContactoPersona);
        builder.Property(i => i.IdContactoPersona)
            .HasColumnName("IdContactoPersona");
        builder.HasOne(ent => ent.Individuo)
           .WithMany(e => e.Contactos)
             .HasForeignKey(e => e.IdPersona);
    }
}
