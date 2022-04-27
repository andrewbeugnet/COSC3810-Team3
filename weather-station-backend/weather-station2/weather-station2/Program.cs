var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(options =>
{
    options.
    AllowAnyOrigin().
    AllowAnyMethod().
    AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
