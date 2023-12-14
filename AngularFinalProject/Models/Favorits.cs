using Microsoft.EntityFrameworkCore;

namespace AngularFinalProject.Models
{
    [PrimaryKey(nameof(RecipeID), nameof(UserId))]
    public class Favorits
    {
        public Guid RecipeID { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Recipe Recipe { get; set; }

        public string UserId { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual ApplicationUser User { get; set; }
    }
}
