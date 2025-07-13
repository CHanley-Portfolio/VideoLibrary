var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.VideoLibrary_Api>("videolibrary-api");

builder.Build().Run();
