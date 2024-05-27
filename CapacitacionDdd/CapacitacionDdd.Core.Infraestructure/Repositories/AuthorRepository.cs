using CapacitacionDdd.Core.Aplication.Contracts.Persistence;
using CapacitacionDdd.Core.Domain.Entities;
using CapacitacionDdd.Core.Infraestructure.Context;

namespace CapacitacionDdd.Core.Infraestructure.Repositories;

public class AuthorRepository : IAuthorRepository
{
    public readonly LibraryContext _context;

    public AuthorRepository(LibraryContext context)
    {
        _context = context;
    }

    public async Task<Author> GetAuthorById(int id)
    {
        return await _context.Athors.FindAsync(id);
    }
    public async Task<Author> GetAuthorByCode(string code)
    {
        return _context.Athors.Where(x => x.Code.Equals(code)).First();
    }

    public async Task<int> AddAuthor(Author author)
    {
        await _context.Athors.AddAsync(author);
        await _context.SaveChangesAsync();
        return author.Id;
    }

    public async Task<int> UpdateAuthor(Author author)
    {
        var existeAuthor = await _context.Athors.FindAsync(author.Id);
        if (existeAuthor != null)
        {
            existeAuthor.Code = author.Code;
            existeAuthor.Name = author.Name;
            existeAuthor.Country = author.Country;
            _context.Athors.Update(existeAuthor);
        }
        var result = await _context.SaveChangesAsync();
        return result;
    }

    public async Task<int> DeleteAuthor(Author author)
    {
        var existeAuthor = await _context.Athors.FindAsync(author.Id);
        if (existeAuthor != null)
        {
            existeAuthor.Code = author.Code;
            existeAuthor.Name = author.Name;
            existeAuthor.Country = author.Country;
            _context.Athors.Remove(existeAuthor);
        }
        var result = await _context.SaveChangesAsync();
        return result;
    }
}
