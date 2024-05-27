using CapacitacionDdd.Core.Domain.Entities;

namespace CapacitacionDdd.Core.Aplication.Contracts.Persistence;

public interface IAuthorRepository
{
    Task<Author> GetAuthorById(int id);

    Task<Author> GetAuthorByCode(string code);

    Task<int> AddAuthor(Author author);

    Task<int> UpdateAuthor(Author author);

    Task<int> DeleteAuthor(Author author);
}
