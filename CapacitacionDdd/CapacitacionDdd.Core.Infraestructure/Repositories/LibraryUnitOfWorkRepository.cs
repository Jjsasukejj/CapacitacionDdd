
using CapacitacionDdd.Core.Aplication.Contracts.Persistence;
using CapacitacionDdd.Core.Infraestructure.Context;

namespace CapacitacionDdd.Core.Infraestructure.Repositories;

public class LibraryUnitOfWorkRepository : ILibraryUnitOfWork
{
    public readonly LibraryContext _libraryContext;

    public LibraryUnitOfWorkRepository(LibraryContext libraryContext)
    {
        _libraryContext = libraryContext;
    }

    IAuthorRepository _authorRepository { get; set; }

    public IAuthorRepository AuthorRepository => _authorRepository ??= new AuthorRepository(_libraryContext);

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
