var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(opt =>
{
    opt.DocumentTitle = "Enviro365Assessment_Jnr_DOTNET";
    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Enviro365Assessment_Jnr_DOTNET");
    opt.RoutePrefix = string.Empty;
});

app.MapGet("/test", () => "Hello World!");
app.Run();