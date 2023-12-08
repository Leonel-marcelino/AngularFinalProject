namespace AngularFinalProject.Models
{
    public class Recipe
    {
        public Guid RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Ingredients>? Ingredients { get; set; }
        public virtual ICollection<Favorits>? Favorites { get; set; }
        public virtual ICollection<Reviews>? Reviews { get; set; }



    }
}
