using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AngularFinalProject.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        public bool IsAdmin { get; set; } = false;

        [Required]
        public bool IsDeleted { get; set; } = false;

        [Required]
        public bool IsLocked { get; set; } = false;

        [Required]
        public DateTime created_date { get; set; } = DateTime.Now;

        public virtual ICollection<Recipe> Recipes { get; set; }

        public virtual ICollection<Favorits> Favorites { get; set; }
    }
}