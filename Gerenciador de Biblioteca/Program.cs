using Gerenciador_de_Biblioteca.ExceptionHandler;
using Gerenciador_de_Biblioteca.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Isso define um novo id sempre que for cadastrado um item
builder.Services.AddScoped<IConfigService, ConfigService>();


builder.Services.AddExceptionHandler<ApiExceptionHandler>();
builder.Services.AddProblemDetails();

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

app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
