namespace NoteBook.Domain.Entites
{
  public class Note
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }

    public Author? Author { get; set; }
    public int? AuthorId { get; set; }
  }
}