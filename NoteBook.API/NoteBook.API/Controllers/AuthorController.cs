using Microsoft.AspNetCore.Mvc;

using NoteBook.Domain.Entites;
using NoteBook.Domain.Repository;

namespace NoteBook.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthorController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;

    public AuthorController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public ActionResult Get() 
    {
      var authors = _unitOfWork.Author.GetAll();
      return Ok(authors);
    }

    [HttpGet("{id}")]
    public ActionResult GetById(int id) 
    { 
      var author = _unitOfWork.Author.GetById(id);
      if (author == null)
        return NotFound("Author no found");
      
      return Ok(author);
    }

    [HttpGet("Notes")]
    public ActionResult GetWithNotes()
    {
      var authors = _unitOfWork.Author.GetAuthorsWithNotes();
      return Ok(authors);
    }

    [HttpPost]
    public ActionResult Add(Author author)
    {
      _unitOfWork.Author.Add(author);
      _unitOfWork.Save();
      return Ok(author);
    }

    [HttpPut]
    public ActionResult Update(Author author)
    {
      _unitOfWork.Author.Update(author);
      _unitOfWork.Save();
      return Ok(author);
    }

    [HttpDelete]
    public ActionResult Delete(Author author)
    {
      _unitOfWork.Author.Remove(author);
      _unitOfWork.Save();
      return Ok(author);
    }
  }
}
