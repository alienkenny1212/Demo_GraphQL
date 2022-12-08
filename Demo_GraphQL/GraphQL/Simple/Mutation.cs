using Demo_Core.Modelos;
using Demo_GraphQL.GraphQL.Estandarizado.Inputs;
using Demo_GraphQL.GraphQL.Estandarizado.Payloads;
using HotChocolate.Subscriptions;

namespace Demo_GraphQL.GraphQL.Simple
{
    public class Mutation
    {
        [UseDbContext(typeof(DemoDbContext))]
        public async Task<PersonaPayload> addPersonaAsync(
        addPersonaInput input,
        [ScopedService] DemoDbContext context,
        [Service] ITopicEventSender sender,
        CancellationToken cancellationToken)
        {
            var persona_new = new Persona()
            {
                Nombre = input.nombre,
                Estado = input.estado,
                FechaNacimiento = input.fechaNacimiento,
            };

            context.Add(persona_new);
            await context.SaveChangesAsync(cancellationToken);
            await sender.SendAsync(nameof(Subscription.OnPersonaAdded), persona_new, cancellationToken);
            return new PersonaPayload(persona_new, "Termine");
        }
    }
}
