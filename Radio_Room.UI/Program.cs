using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Radio_Room.UI;
using Radio_Room.UI.Components;
using Radio_Room.UI.dbContext;
using System;
using System.Linq;
using System.Runtime.CompilerServices;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddTransient<DbInitializer>();
builder.Services.AddDbContext<Radio_RoomDbContext>();

var app = builder.Build();

// 
SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DbInitializer>();
        service.Initialize(builder.Configuration.GetConnectionString("ConnectionStrings:SQLiteDefault"));
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
