namespace Coduniverse.Application.Abstractions.Models
{
    public class StarSystemDTO : BaseDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public SpaceObjectDTO CenterMass { get; set; }
        public IList<SpaceObjectDTO> SpaceObjects { get; set; }
    }
}