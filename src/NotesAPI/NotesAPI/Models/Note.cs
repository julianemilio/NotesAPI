namespace NotesAPI.Models
{
  public class Note
  {
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Author { get; set; } = string.Empty;
   }
}