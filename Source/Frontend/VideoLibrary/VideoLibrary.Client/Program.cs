using FluentValidation;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VideoLibrary.Shared.Models.Movies;
using VideoLibrary.Shared.Models.Validation;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add Fluent Validation
ValidatorOptions.Global.LanguageManager = new ValidationLanguageManager();
builder.Services.AddValidatorsFromAssemblyContaining<EditMovieModel>();


await builder.Build().RunAsync();
