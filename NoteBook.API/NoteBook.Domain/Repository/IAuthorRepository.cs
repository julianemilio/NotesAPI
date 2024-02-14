using NoteBook.Domain.Entites;

namespace NoteBook.Domain.Repository
{
  public interface IAuthorRepository : IGenericRepository<Author>
  {
    IEnumerable<Author> GetAuthorsWithNotes();
  }
}
