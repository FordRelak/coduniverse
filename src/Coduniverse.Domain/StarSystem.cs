using System.Collections.Generic;

namespace Coduniverse.Domain
{
    public class StarSystem : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public SpaceObject CenterMass { get; set; }
        public IList<SpaceObject> SpaceObjects { get; set; }
    }
}