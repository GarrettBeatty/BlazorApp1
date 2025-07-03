var builder = DistributedApplication.CreateBuilder(args);

var blazorApp = builder.AddProject<Projects.BlazorApp1>("blazorapp1");

builder.Build().Run();