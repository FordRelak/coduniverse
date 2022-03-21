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
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllers();

app.UseSpa(conf =>
{
    string strategy = config.GetValue<string>("DevTools:ConnectionStrategy");
    if(strategy == "proxy")
    {
        conf.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
    }
    else if(strategy == "managed")
    {
        conf.Options.SourcePath = "../Coduniverse.Client";
        conf.UseAngularCliServer("start");
    }
});

app.Run();