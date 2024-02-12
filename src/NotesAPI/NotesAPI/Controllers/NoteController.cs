using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesAPI.Models;

namespace NotesAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NoteController : ControllerBase
  {
    public static List<Note> notes = new List<Note> {
      new Note {
        Id = 1,
        Author = "Julian",
        Date = DateTime.Now,
        Content = "Tomar agua" },
      new Note {
        Id = 2,
        Author = "violeta",
        Date = DateTime.Now,
        Content = "jums" }

      };

    [HttpGet]
    public async Task<ActionResult<List<Note>>> GetAllNotes()
    {
      return Ok(notes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<List<Note>>> GetSingleNote(int id)
    {
      var note = notes.Find(x => x.Id == id);
      return Ok(note);
    }

    [HttpPost]
    public async Task<ActionResult<List<Note>>> GetSingleNote(Note note)
    {
      notes.Add(note);
      return Ok(note);
    }
  }
}
