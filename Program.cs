var builder = WebApplication.CreateBuilder(args);

// Lägg till controllers
builder.Services.AddControllers();

// Lägg till Swagger för att testa API:et
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktivera Swagger i utvecklingsläge
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Koppla controllers till rutterna (t.ex. /api/quote)
app.MapControllers();

app.Run();
