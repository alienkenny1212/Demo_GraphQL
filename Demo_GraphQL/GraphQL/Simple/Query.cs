using Demo_Core.Modelos;

namespace Demo_GraphQL.GraphQL.Simple
{
    public class Query
    {
        [UseDbContext(typeof(DemoDbContext))]
        [UseOffsetPaging(IncludeTotalCount = true)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Persona> GetPersonas([ScopedService] DemoDbContext context)
        {
            return context.Set<Persona>();
        }

        [UseDbContext(typeof(DemoDbContext))]
        [UseOffsetPaging(IncludeTotalCount = true)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Contacto> GetContactos([ScopedService] DemoDbContext context)
        {
            return context.Set<Contacto>();
        }
    }
}
