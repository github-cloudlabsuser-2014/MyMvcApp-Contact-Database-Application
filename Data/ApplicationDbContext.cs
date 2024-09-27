using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models; // Ensure this namespace is correct and contains the User class

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}