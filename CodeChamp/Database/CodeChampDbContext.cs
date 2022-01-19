using CodeChamp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeChamp.Database;

public class CodeChampDbContext : DbContext
{
    public CodeChampDbContext(DbContextOptions<CodeChampDbContext> options) : base(options) {}
    
    public DbSet<Post> Posts { get; set; }
}