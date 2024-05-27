using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Queries.GetAuthorById;

public class GetAuthorByIdQuery : IRequest<Author>
{
    public int Id { get; set; }

    public GetAuthorByIdQuery(int id)
    {
        Id = id;
    }
}
