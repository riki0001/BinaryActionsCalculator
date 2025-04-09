using BinaryActionsCalc.Api.Extensions;
using BinaryActionsCalc.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureCors();

builder.ConfigureDBContext();

builder.Services.ConfigureDI();

builder.Services.ConfigureMapper();

builder.Services.ConfigureLogger(builder.Configuration);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("CorsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
