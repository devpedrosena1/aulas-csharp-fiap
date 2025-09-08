using Microsoft.EntityFrameworkCore;
using TodoApp;
using TodoApp.Endpoints;
using TodoApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDatabaseService();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.RegisterTodoItemsEndpoints();

app.Run();