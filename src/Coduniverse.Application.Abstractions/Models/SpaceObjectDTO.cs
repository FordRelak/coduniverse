namespace Coduniverse.Application.Abstractions.Models
{
    public class SpaceObjectDTO : BaseDTO
    {
        public Guid StarSystemId { get; set; }
        public string Age { get; set; }
        public string Name { get; set; }
        public SpaceObjectType Type { get; set; }
        public string TypeName { get; set; }
        public int Diameter { get; set; }
        public int Mass { get; set; }
    }
}