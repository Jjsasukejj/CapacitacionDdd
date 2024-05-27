using CapacitacionDdd.Core.Aplication.Contracts.Persistence;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Command.AddAuthor;

public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, int>
{
    ILibraryUnitOfWork _libraryUnitOfWork;
    public AddAuthorCommandHandler(ILibraryUnitOfWork libraryUnitOfWork)
    {
        _libraryUnitOfWork = libraryUnitOfWork;
    }
    public async Task<int> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
    {
        var result = await _libraryUnitOfWork.AuthorRepository.AddAuthor(request);
        return result;
    }
}
