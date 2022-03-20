namespace Coduniverse.Domain
{
    public class SpaceObject : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public SpaceObjectType Type { get; set; }
        public StarSystem StarSystem { get; set; }
    }
}