using TaskManager.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers (API padrão)
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITaskService, TaskService>();

var app = builder.Build();

// Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapeia Controllers
app.MapControllers();

app.Run();
