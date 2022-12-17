using my_books.Data.Models;
using my_books.Data.ViemModels;

namespace my_books.Data.Services;

public class BookService
{
    private AppDbContext _context;

    public BookService(AppDbContext context)
    {
        _context = context;
    }

    public void AddBook(BookVM book)
    {
        var _book = new Book()
        {
            Title = book.Title,
            Description = book.Description,
            IsRead = book.IsRead,
            DateRead = book.IsRead ? book.DateRead.Value : null,
            Rate = book.IsRead ? book.Rate.Value : null,
            Genre = book.Genre,
            CoverUrl = book.CoverUrl,
            DateAdded = DateTime.Now,
            Author = book.Author
        };
        _context.Books.Add(_book);
        _context.SaveChanges();
    }
}