

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.Run(HandleRequst);
app.Run();
async Task HandleRequst(HttpContext context)
{
    await context.Response.WriteAsync("Hello METANIT.COM 2");
}

/*
await app.StartAsync();
await Task.Delay(3000);
await app.StopAsync();
*/


