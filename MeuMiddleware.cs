public class MeuMiddleware
{
    private readonly RequestDelegate _next;

    public MeuMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        System.Console.WriteLine("\n\r-- A --\n\r");
         await _next(context);
        System.Console.WriteLine("\n\r-- D --\n\r");
    }
}