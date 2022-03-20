namespace Coduniverse.Application.Abstractions.Models
{
    public class SpaceObjectDTO
    {
        public Guid StarSystemId { get; set; }

        public string Age { get; set; }

        public string Name { get; set; }

        public SpaceObjectType Type { get; set; }
    }
}