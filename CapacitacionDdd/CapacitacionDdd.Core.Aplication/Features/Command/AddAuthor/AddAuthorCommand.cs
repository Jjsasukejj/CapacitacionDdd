using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Command.AddAuthor;

public class AddAuthorCommand : Author, IRequest<int>
{

}
