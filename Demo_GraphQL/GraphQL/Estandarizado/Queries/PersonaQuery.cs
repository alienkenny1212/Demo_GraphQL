using Demo_Core.Modelos;
using Demo_GraphQL.GraphQL.Estandarizado.Filters;

namespace Demo_GraphQL.GraphQL.Estandarizado.Queries
{
    [ExtendObjectType("Query")]
    public class PersonaQuery
    {
        [UseDbContext(typeof(DemoDbContext))]
        [UseOffsetPaging(IncludeTotalCount = true)]
        [UseProjection]
        [UseFiltering(typeof(PersonaCustomFilter))]
        [UseSorting]
        public IQueryable<Persona> GetPersonas([ScopedService] DemoDbContext context)
        {
            return context.Set<Persona>();
        }
    }
}
