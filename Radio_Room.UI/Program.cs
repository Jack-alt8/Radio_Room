using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
builder.Services.AddDbContext<Radio_RoomDbContext>();
builder.Services.AddSingleton<IDialogueService, DialogueService>();
builder.Services.AddTransient<ProgressSaver>();

var app = builder.Build();

SaveProgress(app);

void SaveProgress(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<ProgressSaver>();
        ProgressSaver.StartFileWrite();
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
