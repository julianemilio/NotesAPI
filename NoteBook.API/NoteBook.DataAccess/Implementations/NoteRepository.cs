using NoteBook.Domain.Entites;
using NoteBook.Domain.Repository;

namespace NoteBook.DataAccess.Implementations
{
  public class NoteRepository : GenericRepository<Note>, INoteRepository
  {
    public NoteRepository(NoteBookDbContext context) : base(context)
    {
    }
  }
}
