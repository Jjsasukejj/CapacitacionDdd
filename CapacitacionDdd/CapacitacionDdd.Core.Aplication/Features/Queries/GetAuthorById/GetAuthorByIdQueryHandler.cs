using CapacitacionDdd.Core.Aplication.Contracts.Persistence;
using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Queries.GetAuthorById;

public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, Author>
{
    ILibraryUnitOfWork _libraryUnitOfWork;

    public GetAuthorByIdQueryHandler(ILibraryUnitOfWork libraryUnitOfWork)
    {
        _libraryUnitOfWork = libraryUnitOfWork;
    }

    public async Task<Author> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _libraryUnitOfWork.AuthorRepository.GetAuthorById(request.Id);
        return result;
    }
}
