// See https://aka.ms/new-console-template for more information

using _5_EntityFrameqorkSqlLite;
using _5_EntityFrameqorkSqlLite.Entities;
using var db = new BloggingContext();

Console.WriteLine($"Database path: {db.DbPath}");

// create
Console.WriteLine("Inserting a new blog");
db.Blogs.Add(new Blog(){Url = "http://blogs.msdn.com/adonet"});
await db.SaveChangesAsync();

// read
Console.WriteLine("Querying for a blog");
var blog = await db.Blogs.FindAsync(1);
Console.WriteLine(blog.Url);

// update
Console.WriteLine("Updating a blog and adding a post");
blog.Url = "http://devblogs.microsoft.com/dotnet/";
blog.Posts.Add(new Post()
{
    Title = "Title test",
    Content = "Content test",
});
await db.SaveChangesAsync();
Console.WriteLine(blog.Posts.Count);

// delete
Console.WriteLine("Deleting a blog");
db.Blogs.Remove(blog);
await db.SaveChangesAsync();