using Microsoft.AspNetCore.Mvc;
using NoteBook.Domain.Entites;
using NoteBook.Domain.Repository;

namespace NoteBook.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NoteController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;

    public NoteController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public ActionResult Get()
    {
      var notes = _unitOfWork.Note.GetAll();
      return Ok(notes);
    }

    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
      var note = _unitOfWork.Note.GetById(id);
      if (note == null)
        return NotFound("Note no found");

      return Ok(note);
    }

    [HttpPost]
    public ActionResult Add(Note note)
    {
      _unitOfWork.Note.Add(note);
      _unitOfWork.Save();
      return Ok(note);
    }

    [HttpPut]
    public ActionResult Update(Note note)
    {
      _unitOfWork.Note.Update(note);
      _unitOfWork.Save();
      return Ok(note);
    }

    [HttpDelete]
    public ActionResult Delete(Note note)
    {
      _unitOfWork.Note.Remove(note);
      _unitOfWork.Save();
      return Ok(note);
    }
  }
}
