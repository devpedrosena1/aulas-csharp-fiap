using System.Configuration;
using _6_EntityFrameworkOracle.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6_EntityFrameworkOracle.Entities;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    public string DbPath { get; }

    // ctor -> generate method constructor emptty

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    
        => optionsBuilder.UseOracle(
            ConfigurationManager.ConnectionStrings["FiapOracle"]?.ConnectionString ?? 
            "Data Source=//oracle.fiap.com.br:1521/orcl;User Id=rm561178; Password=200905;");
}