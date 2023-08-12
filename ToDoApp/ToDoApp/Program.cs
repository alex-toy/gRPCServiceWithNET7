using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;
using ToDoApp.Services;
using ToDoGrpc.Services;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetSection("ConnectionStrings:constring").Value;


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddGrpc().AddJsonTranscoding();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ToDoService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
