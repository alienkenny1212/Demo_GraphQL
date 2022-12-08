using Demo_Core.Modelos;

namespace Demo_GraphQL.GraphQL.Simple;

public class Subscription
{
    [Subscribe]
    [Topic]
    public Persona OnPersonaAdded([EventMessage] Persona persona)
    {
        return persona;
    }
}
