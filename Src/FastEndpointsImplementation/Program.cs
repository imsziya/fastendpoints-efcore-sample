using FastEndpoints;
using FastEndpoints.Swagger;
using FastEndpointsImplementation.Endpoints;
using FastEndpointsImplementation.Models.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("AppDb"));

builder.Services.AddFastEndpoints(o =>
{
    o.Assemblies = [typeof(CreateCustomerEndpoint).Assembly];
});

builder.Services.SwaggerDocument(o =>
{
    o.DocumentSettings = s =>
    {
        s.Title = "Customer API";
        s.Version = "v1";
    };
});

var app = builder.Build();

app.UseFastEndpoints(); 
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerGen();
    app.UseSwaggerUI(c => c.RoutePrefix = "swagger");
}
app.Run();
