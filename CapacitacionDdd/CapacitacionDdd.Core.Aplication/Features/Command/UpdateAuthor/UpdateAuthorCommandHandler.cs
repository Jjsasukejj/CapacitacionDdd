
using CapacitacionDdd.Core.Aplication.Contracts.Persistence;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Command.UpdateAuthor;

public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, int>
{
    ILibraryUnitOfWork _libraryUnitOfWork;
    public UpdateAuthorCommandHandler(ILibraryUnitOfWork libraryUnitOfWork)
    {
        _libraryUnitOfWork = libraryUnitOfWork;
    }
    public async Task<int> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
    {
        var result = await _libraryUnitOfWork.AuthorRepository.UpdateAuthor(request);
        return result;
    }
}
