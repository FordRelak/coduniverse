using System.ComponentModel.DataAnnotations;

namespace Coduniverse.WebApi.Models
{
    public class SpaceObjectInput
    {
        public Guid Id { get; set; }

        [Required]
        public Guid StarSystemId { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public string Age { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public SpaceObjectType Type { get; set; }
    }
}