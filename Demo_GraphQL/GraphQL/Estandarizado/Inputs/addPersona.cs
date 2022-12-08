using Demo_Core.Modelos;

namespace Demo_GraphQL.GraphQL.Estandarizado.Inputs
{
    public record addPersonaInput(
        string nombre, 
        EstadoPersona estado,
        DateTime fechaNacimiento);
}
