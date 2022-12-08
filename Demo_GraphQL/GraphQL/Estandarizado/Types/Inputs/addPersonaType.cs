using Demo_GraphQL.GraphQL.Estandarizado.Inputs;

namespace Demo_GraphQL.GraphQL.Estandarizado.Types.Inputs
{
    public class addPersonaType : ObjectType<addPersonaInput>
    {
        protected override void Configure(IObjectTypeDescriptor<addPersonaInput> descriptor)
        {
            descriptor.Description("Datos para recibir una persona");
            descriptor.Field(p => p.nombre).Description("Nombre/Apellido");
            descriptor.Field(p => p.estado).Description("Estado de animo");
            descriptor.Field(p => p.fechaNacimiento).Description("Cuando nació");
        }
    }
}
