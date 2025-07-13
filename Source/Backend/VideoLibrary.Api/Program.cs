using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using VideoLibrary.Data;
using VideoLibrary.Service.Interfaces;
using VideoLibrary.Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add DB service
builder.Services.AddDbContext<VideoLibraryContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("VideoLibraryDB"), x => x.MigrationsAssembly("VideoLibrary.Data"));
});

// Add services to the container.
builder.Services.AddScoped<ILookupService, LookupService>();

builder.Services.AddControllers();

// Add Swagger OpenAPI services
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Video Library API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Video Library V1");

    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
