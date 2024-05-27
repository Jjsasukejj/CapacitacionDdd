using CapacitacionDdd.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CapacitacionDdd.Core.Infraestructure.Context;

public class LibraryContext : DbContext
{
    public DbSet<Author> Athors { get; set; }

    public LibraryContext(DbContextOptions<LibraryContext> option) : base(option)
    {
        
    }
}
