namespace NoteBook.Domain.Entites
{
  public class Author
  {
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<Note>? Notes { get; set; }
  }
}
