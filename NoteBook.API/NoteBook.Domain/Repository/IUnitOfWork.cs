namespace NoteBook.Domain.Repository
{
  public interface IUnitOfWork : IDisposable
  {
    IAuthorRepository Author {  get; }
    INoteRepository Note { get; }
    int Save();
  }
}
