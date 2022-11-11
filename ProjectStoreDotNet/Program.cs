using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ProjectStoreDotNet.Repository;
using ProjectStoreDotNet.Swagger;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>();
builder.Services.AddScoped<IStoreContext, StoreContext>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Store API",
        Description = "Projeto de que busca simular a API de uma Loja",
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    options.SchemaFilter<SwaggerIdFilter>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "docs";

});

app.UseSwagger(options =>
{
    options.SerializeAsV2 = true;
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
