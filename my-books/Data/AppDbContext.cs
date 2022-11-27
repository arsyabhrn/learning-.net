using Microsoft.EntityFrameworkCore;

namespace my_books.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
        
    }
}