var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.VideoLibrary_Api>("videolibrary-api");

builder.AddProject<Projects.VideoLibrary>("videolibrary");

builder.Build().Run();
