
using CerebroApi.Infraestructure.Services;
using CerebroApi.Services;
using CerebroApi.Infraestructure.Agent;
using CerebroApi.Agents.Marvel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Asignar una Interface a una clase para cada vez que se instancie
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<IMarvelAgent, MarvelAgent>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
