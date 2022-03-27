using System.ComponentModel.DataAnnotations;

namespace Coduniverse.WebApi.Models
{
    public class StarSystemInput
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
    }
}