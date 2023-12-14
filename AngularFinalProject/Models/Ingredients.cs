using System.ComponentModel.DataAnnotations;

namespace AngularFinalProject.Models
{
    public class Ingredients
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; }

        [Required]
        public string Quantity { get; set; }
    }
}
