using Coduniverse.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coduniverse.Infrastructure.EF.Configurations
{
    public class StarSystemConfiguration : IEntityTypeConfiguration<StarSystem>
    {
        public void Configure(EntityTypeBuilder<StarSystem> builder)
        {
            builder.ToTable("starSystems");

            builder.HasKey(entity => entity.Id);

            builder.HasMany(starSystem => starSystem.SpaceObjects)
                .WithOne(spaceObject => spaceObject.StarSystem).OnDelete(DeleteBehavior.Cascade);


            builder.Property<Guid?>("CenterMassId");
            builder.HasOne(s => s.CenterMass)
                .WithMany().HasForeignKey("CenterMassId");
        }
    }
}