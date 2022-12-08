using Demo_Core.Modelos;

namespace Demo_GraphQL.GraphQL.Estandarizado.Queries
{
    [ExtendObjectType("Query")]
    public class ContactoQuery
    {
        [UseDbContext(typeof(DemoDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Contacto> GetContactos([ScopedService] DemoDbContext context)
        {
            return context.Set<Contacto>();
        }
    }
}
