using Enviro365Assessment_Jnr_DOTNET.Data;
using Enviro365Assessment_Jnr_DOTNET.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddTransient<IFIleRepository, FileRepository>();
builder.Services.AddLogging();
builder.Services.AddControllers();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(opt =>
{
    opt.DocumentTitle = "Environment System API ";
    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Environment API V1");
    opt.RoutePrefix = string.Empty;
});

app.Logger.LogInformation("Application Started");
app.MapControllers();
app.MapGet("/test", () => "Hello World!");
app.Run();