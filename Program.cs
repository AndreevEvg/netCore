var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddRazorPages();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseMvcWithDefaultRoute();
app.MapRazorPages();
app.UseStaticFiles();

app.Run();

//https://disk.yandex.ru/d/sBmi3uZ9p64XYQ