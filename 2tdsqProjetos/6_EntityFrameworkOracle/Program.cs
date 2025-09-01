// See https://aka.ms/new-console-template for more information

using _6_EntityFrameworkOracle.Entities;

var db = new BloggingContext();

// create
Console.WriteLine("Inserting a new blog");
db.Blogs.Add(new Blog(){Url = "http://blogs.msdn.com/adonet"});
await db.SaveChangesAsync();

// read
Console.WriteLine("Querying for a blog");
var blog = await db.Blogs.FindAsync(1);
Console.WriteLine(blog.Url);