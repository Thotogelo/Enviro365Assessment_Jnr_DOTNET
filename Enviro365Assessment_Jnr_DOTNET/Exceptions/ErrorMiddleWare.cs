
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Enviro365Assessment_Jnr_DOTNET.Exceptions;
public class ErrorMiddleWare
{
    private readonly ILogger _logger;
    private readonly RequestDelegate _next;

    public ErrorMiddleWare(RequestDelegate next, ILogger<ErrorMiddleWare> logger)
    {
        _next = next;
        _logger = logger;
    }


    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            context.Response.ContentType = "application/json";

            context.Response.StatusCode = ex.Message switch
            {
                "The file is not a text file, please upload a valid text file." => StatusCodes.Status400BadRequest,
                "The file is empty, please upload a file with contents." => StatusCodes.Status204NoContent,
                "The file is too large, please upload a file less than 500kb." => StatusCodes.Status413PayloadTooLarge,
                _ => StatusCodes.Status500InternalServerError,
            };
            ProblemDetails errorResponse = new()
            {
                Title = ex.Message,
                Status = context.Response.StatusCode,
                Instance = context.Request.Path.Value,
            };

            _logger.LogCritical(ex, "Exception has been thrown, from FileException: ");
            await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
        }
    }
}
