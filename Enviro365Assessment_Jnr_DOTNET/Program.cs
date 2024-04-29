using Enviro365Assessment_Jnr_DOTNET.Data;
using Enviro365Assessment_Jnr_DOTNET.Exceptions;
using Enviro365Assessment_Jnr_DOTNET.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddTransient<IFIleRepository, FileRepository>();
builder.Services.AddLogging();
builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Environment Data API", Version = "v1" });
});

var app = builder.Build();

app.UseMiddleware<ErrorMiddleWare>();
app.UseSwagger();
app.UseSwaggerUI(opt =>
{
    opt.DocumentTitle = "Environment System API ";
    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Environment Data API V1");
    opt.RoutePrefix = string.Empty;
});

app.Logger.LogInformation("Application Started");
app.MapControllers();
app.MapGet("/test", () => "Hello World!");
app.Run();