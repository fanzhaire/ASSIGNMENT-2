using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem;

public class LibraryContext : DbContext
{
    public DbSet<Account> loginaccount { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<userbooks> userbooks { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(@"Server=localhost;Port=3306;Database=library;User ID=root;Password=fzy990708;",
            new MySqlServerVersion(new Version(8, 0, 21)),
            mysqlOptions =>
            {
                mysqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null);
            });
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<userbooks>()
            .HasKey(ub => new { ub.UserId, ub.BookId });
    }
}


