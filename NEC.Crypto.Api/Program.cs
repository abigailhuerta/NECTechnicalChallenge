using NEC.Crypto.Controllers;
using NEC.Crypto.HttpRequests;
using NEC.Crypto.Loggers;
using NEC.Crypto.UseCases;
using NorthWind.Sales.Presenters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpRequest(builder.Configuration["ApiKey"])
                .AddNecCryptoControllers()
                .AddUseCasesServices()
                .AddPresenters()
                .AddLogger();


builder.Services.AddCors(options =>
{
    options.AddPolicy("default", config =>
    {
        config.AllowAnyMethod();
        config.AllowAnyHeader();
        config.AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("default");
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();

app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();
