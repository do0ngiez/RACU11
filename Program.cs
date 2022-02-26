using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RACU11.ViewModels;
using RACU11.Models;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<RACU11Context>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("RACU11Context")));
}

builder.Services.AddDbContext<RACU11Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RACU11Context")));

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// configure Mapster
TypeAdapterConfig<CreateIRF, IRF>
    .NewConfig()
    .NameMatchingStrategy(NameMatchingStrategy.ConvertSourceMemberName(name => name.Replace("IRF_", "")));//removes IRF_
TypeAdapterConfig<CreateIRF, ReportingPerson>
    .NewConfig()
    .NameMatchingStrategy(NameMatchingStrategy.ConvertSourceMemberName(name => name.Replace("ReportingPerson_", "")));
TypeAdapterConfig<CreateIRF, Suspect>
    .NewConfig()
    .NameMatchingStrategy(NameMatchingStrategy.ConvertSourceMemberName(name => name.Replace("Suspect_", "")));
TypeAdapterConfig<CreateIRF, Children>
    .NewConfig()
    .NameMatchingStrategy(NameMatchingStrategy.ConvertSourceMemberName(name => name.Replace("Children_", "")));
TypeAdapterConfig<CreateIRF, Victim>
    .NewConfig()
    .NameMatchingStrategy(NameMatchingStrategy.ConvertSourceMemberName(name => name.Replace("Victim_", "")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
