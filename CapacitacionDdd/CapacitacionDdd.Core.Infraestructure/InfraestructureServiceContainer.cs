using CapacitacionDdd.Core.Aplication.Contracts.Persistence;
using CapacitacionDdd.Core.Infraestructure.Context;
using CapacitacionDdd.Core.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CapacitacionDdd.Core.Infraestructure;

public class InfraestructureServiceContainer
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<LibraryContext>(options => options.UseInMemoryDatabase("Library"));
        using (var context = services.BuildServiceProvider().GetService<LibraryContext>())
        {
            context!.Athors.Add(new Domain.Entities.Author { Id=1, Code="A1", Name="Jorge Icaza", Country="Ecuador"});
            context!.Athors.Add(new Domain.Entities.Author { Id=2, Code="A2", Name="Juan Montalvo", Country="Ecuador"});
            context.SaveChanges();
        }

        services.AddScoped<ILibraryUnitOfWork, LibraryUnitOfWorkRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
    }
}
