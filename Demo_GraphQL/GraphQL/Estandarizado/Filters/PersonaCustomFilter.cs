using Demo_Core.Modelos;
using HotChocolate.Data.Filters;

namespace Demo_GraphQL.GraphQL.Estandarizado.Filters;

public class PersonaCustomFilter : FilterInputType<Persona>
{
    protected override void Configure(IFilterInputTypeDescriptor<Persona> descriptor)
    {
        descriptor.Name("PersonaCustomFilter");
        descriptor.Field(f => f.IdPersona).Name("llave");
        descriptor.Field(f => f.FechaNacimiento).Ignore();
    }
}