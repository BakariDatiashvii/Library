using Library.DbContex;
using Library.Repository;
using Library.RepositoryFolder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAutorRepository, AutorRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookInfoRepository, BookInfoRepository>();
builder.Services.AddScoped<IMkitxveliRepository, MkitxveliRepository>();
builder.Services.AddScoped<IBook_MkitxveliRepository,  Book_MkitxveliRepository>();
builder.Services.AddDbContext<LibraryDbContext>(option =>
{
    option.UseSqlServer(@"Server=DESKTOP-MRACR18\SQLEXPRESS01;Database=BIBLIOTEKA;Trusted_Connection=True;TrustServerCertificate=True;");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
