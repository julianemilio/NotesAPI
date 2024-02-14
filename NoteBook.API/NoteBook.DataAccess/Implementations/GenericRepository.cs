using NoteBook.Domain.Repository;

namespace NoteBook.DataAccess.Implementations
{
  public class GenericRepository<T> : IGenericRepository<T> where T : class
  {
    protected readonly NoteBookDbContext _context;

    public GenericRepository(NoteBookDbContext context)
    {
      _context = context;
    }
    public void Add(T entity)
    {
      _context.Set<T>().Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
      _context.Set<T>().AddRange(entities);
    }

    public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
    {
      return _context.Set<T>().Where(predicate);
    }

    public IEnumerable<T> GetAll()
    {
      return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
      return _context.Set<T>().Find(id);
    }

    public void Update(T entity)
    {
      _context.Set<T>().Update(entity);
    }
    public void Remove(T entity)
    {
      _context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
      _context.Set<T>().RemoveRange(entities);
    }
  }
}
