using Coduniverse.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Security.Cryptography;

namespace Coduniverse.Infrastructure.EF
{
    public class EfDbContext : DbContext
    {
        public DbSet<StarSystem> StarSystems { get; set; }
        public DbSet<SpaceObject> SpaceObjects { get; set; }

        public EfDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured)
                return;
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=coduniversedb;User Id=coduniverseu;Password=coduniversep;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var solarSystemGuid = Guid.Parse("e8e87f06-eb9e-40e5-a9ca-2740da47bf61");
            var solarStarGuid = Guid.Parse("970ba570-e757-48b0-84cc-52235a35a10c");

            var obj1 = Guid.Parse("340AA24A-9EE2-4514-875F-41CF64126A85");
            var obj2 = Guid.Parse("cff1a755-d896-4e57-8aa1-82df408639ee");
            var obj3 = Guid.Parse("b184eaea-de80-47e1-a0af-ce08d93a7524");
            var obj4 = Guid.Parse("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14");
            var obj5 = Guid.Parse("60269d83-0267-4896-a067-377b8a4afb3d");

            var time = DateTimeOffset.UtcNow;

            var solarStar = new
            {
                Id = solarStarGuid,
                Age = RandomNumberGenerator.GetInt32(int.MaxValue),
                Name = "Solar",
                Type = SpaceObjectType.Star,
                StarSystemId = solarSystemGuid,
                CreatedAt = time,
                UpdatedAt = time,
                CenterMassId = solarSystemGuid,
                Diameter = RandomNumberGenerator.GetInt32(int.MaxValue),
                Mass = RandomNumberGenerator.GetInt32(int.MaxValue),
            };

            var starSystem = new
            {
                Id = solarSystemGuid,
                Age = RandomNumberGenerator.GetInt32(int.MaxValue),
                CenterMassId = solarStarGuid,
                Name = "Solar system",
                CreatedAt = time,
                UpdatedAt = time,
            };

            modelBuilder.Entity<StarSystem>().HasData(
                starSystem
            );

            modelBuilder.Entity<SpaceObject>()
                .HasData(
                    solarStar,
                    new
                    {
                        Age = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Id = obj1,
                        Name = "Mercury",
                        Type = SpaceObjectType.Planet,
                        StarSystemId = starSystem.Id,
                        CreatedAt = time,
                        UpdatedAt = time,
                        Diameter = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Mass = RandomNumberGenerator.GetInt32(int.MaxValue),
                    },
                    new
                    {
                        Age = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Id = obj2,
                        Name = "Venus",
                        Type = SpaceObjectType.Planet,
                        StarSystemId = starSystem.Id,
                        CreatedAt = time,
                        UpdatedAt = time,
                        Diameter = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Mass = RandomNumberGenerator.GetInt32(int.MaxValue),
                    },
                    new
                    {
                        Age = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Id = obj3,
                        Name = "Earth",
                        Type = SpaceObjectType.Planet,
                        StarSystemId = starSystem.Id,
                        CreatedAt = time,
                        UpdatedAt = time,
                        Diameter = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Mass = RandomNumberGenerator.GetInt32(int.MaxValue),
                    },
                    new
                    {
                        Age = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Id = obj4,
                        Name = "Mars",
                        Type = SpaceObjectType.Planet,
                        StarSystemId = starSystem.Id,
                        CreatedAt = time,
                        UpdatedAt = time,
                        Diameter = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Mass = RandomNumberGenerator.GetInt32(int.MaxValue),
                    },
                    new
                    {
                        Age = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Id = obj5,
                        Name = "Jupiter",
                        Type = SpaceObjectType.Planet,
                        StarSystemId = starSystem.Id,
                        CreatedAt = time,
                        UpdatedAt = time,
                        Diameter = RandomNumberGenerator.GetInt32(int.MaxValue),
                        Mass = RandomNumberGenerator.GetInt32(int.MaxValue),
                    }
                );

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries()
                                       .Where(e => e.Entity is BaseEntity 
                                       && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach(var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTimeOffset.UtcNow;

                if(entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTimeOffset.UtcNow;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}