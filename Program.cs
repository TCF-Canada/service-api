var builder = WebApplication.CreateBuilder(args);
// Register services needed for Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "My API",
        Version = "v1",
        Description = "A simple example ASP.NET Core Web API"
    });
});

// Add services to the container.
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();      // Serve Swagger JSON
    app.UseSwaggerUI();    // Serve Swagger UI web page
}
app.MapGet("/test", () => "Hello World!");

app.Run();
