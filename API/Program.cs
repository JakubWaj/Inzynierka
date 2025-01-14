using System.Text.Json.Serialization;
using Application;
using Application.Features.Country;
using Infrastructure;
using Infrastructure.Middleware;
using Infrastructure.Persistence;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddControllers();
builder.Services.AddEndpointsApiExplorer();
AppContext.SetSwitch("System.Runtime.Serialization.Formatters.BinaryFormatterSerializationEnabled", true);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
} );
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new() { Title = "Movies", Version = "v1" });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference()
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.Run();

