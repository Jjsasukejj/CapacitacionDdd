using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Aplication.Features.Queries.GetAuthorByCode;

public class GetAuthorByCodeQuery : IRequest<Author>
{
    public string Code { get; set; }

    public GetAuthorByCodeQuery(string code)
    {
        Code = code;
    }
}
