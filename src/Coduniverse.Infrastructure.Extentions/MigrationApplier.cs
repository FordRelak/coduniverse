﻿using Coduniverse.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Coduniverse.Infrastructure.Extentions
{
    public static class MigrationApplier
    {
        public static IHost ApplyMigrations(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<EfDbContext>();
            context.Database.Migrate();
            return host;
        }
    }
}