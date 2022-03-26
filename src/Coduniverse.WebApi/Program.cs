using Coduniverse.Application.Services;
using Coduniverse.Infrastructure.Extentions;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var environment = builder.Environment;
var services = builder.Services;
var config = builder.Configuration;

services.AddInfrasctuctureEf(config);
services.AddApplicationServices(config);

services.AddCors();

services.AddAutoMapper(Assembly.GetExecutingAssembly());

services.AddControllers().AddNewtonsoftJson(opt =>
{
    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

var app = builder.Build();
if(environment.IsDevelopment())
{
    app.ApplyMigrations();
    app.UseDeveloperExceptionPage();
}

app.UseCors(config => config.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowCredentials().AllowAnyMethod());

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllers();

app.UseSpa(conf =>
{
    if(environment.IsProduction())
    {
        conf.Options.SourcePath = "../Coduniverse.Client";
        conf.UseAngularCliServer("start");
    }
});

app.Run();