using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem;

public class LibraryContext : DbContext
{
    public DbSet<Account> loginaccount { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(@"Server=localhost;Port=3306;Database=library;User ID=root;Password=123456;",
            new MySqlServerVersion(new Version(8, 0, 21)));
    }
}


