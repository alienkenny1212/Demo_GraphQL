var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<DemoDbContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
    c.EnableSensitiveDataLogging();
});

builder.Services.AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<PersonaQuery>()
    .AddType<ContactoQuery>()
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<AddPersona>()
    .AddSubscriptionType(s => s.Name("Subscription"))
    .AddType<PersonaSubscription>()
    //Resto de Types
    .AddType<PersonaType>()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .AddInMemorySubscriptions();

var app = builder.Build();

app.UseWebSockets();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.UseGraphQLVoyager("/graphql-voyager", new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql",
});

app.Run();
