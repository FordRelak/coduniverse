using Coduniverse.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coduniverse.Infrastructure.EF.Configurations
{
    public class SpaceObjectConfiguration : IEntityTypeConfiguration<SpaceObject>
    {
        private const string STAR_SYSTEM_ID_COLUMN = "StarSystemId";
        public void Configure(EntityTypeBuilder<SpaceObject> builder)
        {
            builder.ToTable("spaceObjects");

            builder.HasKey(entity => entity.Id);

            builder.Property<Guid>(STAR_SYSTEM_ID_COLUMN);
            builder.HasOne(spaceObj => spaceObj.StarSystem)
                .WithMany(starSystem => starSystem.SpaceObjects)
                .HasForeignKey(STAR_SYSTEM_ID_COLUMN);

        }
    }
}