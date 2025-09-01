using _5_EntityFrameqorkSqlLite.Entities;
using Microsoft.EntityFrameworkCore;

namespace _5_EntityFrameqorkSqlLite;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    public string DbPath { get; }

    // ctor -> generate method constructor empty
    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"DataSource={DbPath}");
}