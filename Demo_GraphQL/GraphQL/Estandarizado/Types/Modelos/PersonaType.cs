using Demo_Core.Modelos;

namespace Demo_GraphQL.GraphQL.Estandarizado.Types.Modelos;

public class PersonaType : ObjectType<Persona>
{
    protected override void Configure(IObjectTypeDescriptor<Persona> descriptor)
    {
        descriptor.Description("Personas del demo");
        descriptor.Field(p => p.IdPersona).Description("Llave primaria").Name("idPersona");
        //descriptor.Field(p => p.Contactos).Description("A donde comunicarnos con esa persona");
        descriptor
        .Field(p => p.Contactos)
        .ResolveWith<Resolvers>(p => p.GetContactos(default!, default!))
        .UseDbContext<DemoDbContext>();
    }

    private class Resolvers
    {
        public List<Contacto> GetContactos([Parent] Persona predefinido, [ScopedService] DemoDbContext context)
        {
            var contactos = context.Set<Contacto>().Where(p => p.IdPersona == predefinido.IdPersona).ToList();
            return contactos;
        }
    }
}
