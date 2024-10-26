using LibraryManagement.Domain.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configura el DbContext con la cadena de conexi�n
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryDatabase")));

var app = builder.Build();

// Configuraci�n adicional...
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
