using APICatalogo.Context;
using APICatalogo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(OptionsBuilderConfigurationExtensions =>
    optionsBuilderConfigurationExtensions.UseMySql(mySqlConnection,
    ServerVersion.AutoDetect(mySqlConnection)));

builder.Services.AddScoped<Categoria, Categoria>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();