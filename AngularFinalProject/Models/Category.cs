using System.ComponentModel.DataAnnotations;

namespace AngularFinalProject.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
