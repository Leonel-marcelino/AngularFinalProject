using Microsoft.AspNetCore.Identity;

namespace AngularFinalProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Favorits> Favorits { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }

    }
}