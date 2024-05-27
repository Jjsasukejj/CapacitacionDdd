using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Command.UpdateAuthor;

public class UpdateAuthorCommand : Author, IRequest<int>
{
}
