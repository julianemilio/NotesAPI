using NoteBook.Domain.Repository;

namespace NoteBook.DataAccess.Implementations
{
  public  class UnitOfWork : IUnitOfWork
  {
    private readonly NoteBookDbContext _context;
    public UnitOfWork(NoteBookDbContext context)
    {
      _context = context;
      Author = new AuthorRepository(_context);
      Note = new NoteRepository(_context);
    }

    public IAuthorRepository Author { get; private set; }
    public INoteRepository Note { get; private set; }

    public int Save()
    {
      return _context.SaveChanges();
    }
    public void Dispose()
    {
      _context.Dispose();
    }
  }
}
