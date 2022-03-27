using System.ComponentModel.DataAnnotations;

namespace Coduniverse.WebApi.Models
{
    public class MakeCenterMassInput
    {
        [Required]
        public Guid SpaceObjectId { get; set; }

        [Required]
        public Guid StarSystemId { get; set; }
    }
}