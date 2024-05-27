
namespace CapacitacionDdd.Core.Aplication.Contracts.Persistence;

public interface ILibraryUnitOfWork : IDisposable
{
    IAuthorRepository AuthorRepository { get; }
}
