using BookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Data;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

    }

    public DbSet<Author> Authors {get; set;}
    public DbSet<Book> Books {get; set;}
}