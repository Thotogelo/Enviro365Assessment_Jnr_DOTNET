using Enviro365Assessment_Jnr_DOTNET.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(opt =>
{
    opt.DocumentTitle = "Environment System API ";
    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Environment API V1");
    opt.RoutePrefix = string.Empty;
});

app.MapGet("/test", () => "Hello World!");
app.Run();