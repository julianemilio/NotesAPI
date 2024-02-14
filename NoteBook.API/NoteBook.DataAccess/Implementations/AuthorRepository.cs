using Microsoft.EntityFrameworkCore;

using NoteBook.Domain.Entites;
using NoteBook.Domain.Repository;

namespace NoteBook.DataAccess.Implementations
{
  public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
  {
    public AuthorRepository(NoteBookDbContext context) : base(context)
    {
    }

    public IEnumerable<Author> GetAuthorsWithNotes()
    {
      var authors = _context.Authors.Include(x => x.Notes).ToList();
      return authors; 
    }
  }
}
