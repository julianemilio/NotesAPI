using Microsoft.EntityFrameworkCore;

using NoteBook.Domain.Entites;


namespace NoteBook.DataAccess
{
  public class NoteBookDbContext : DbContext
  {
    public NoteBookDbContext(DbContextOptions<NoteBookDbContext> options) : base(options) { }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Author>().HasData(
        new Author { Id = 1, FirstName = "Juan", LastName = "Ropero", UserName = "JRopero" },
        new Author { Id = 2, FirstName = "Julian", LastName = "Osorio", UserName = "JOsorio" } 
      );
      modelBuilder.Entity<Note>().HasData(
        new Note { Id = 1, Title = "task-1", Content = "Wash the car", AuthorId = 1 },
        new Note { Id = 2, Title = "task-2", Content = "Wash the house", AuthorId = 1 },
        new Note { Id = 3, Title = "task-3", Content = "buy roses", AuthorId = 1 },
        new Note { Id = 4, Title = "task-4", Content = "buy pizzas", AuthorId = 1 }
      );
    }
  }
}
