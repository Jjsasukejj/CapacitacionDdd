using CapacitacionDdd.Core.Aplication.Contracts.Persistence;
using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Queries.GetAuthorByCode;

public class GetAuthorByCodeQueryHandler : IRequestHandler<GetAuthorByCodeQuery, Author>
{
    ILibraryUnitOfWork _libraryUnitOfWork;

    public GetAuthorByCodeQueryHandler(ILibraryUnitOfWork libraryUnitOfWork)
    {
        _libraryUnitOfWork = libraryUnitOfWork;
    }

    public async Task<Author> Handle(GetAuthorByCodeQuery request, CancellationToken cancellationToken)
    {
        var result = await _libraryUnitOfWork.AuthorRepository.GetAuthorByCode(request.Code);
        return result;
    }
}
