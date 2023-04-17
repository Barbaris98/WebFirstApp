

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!222222222222222222222 World!Hello World!");

//app.Run();


await app.StartAsync();
await Task.Delay(3000);
await app.StopAsync();



