namespace AngularFinalProject.Models
{
    public class Reviews
    {
        
        public int Rating { get; set; }
        
        public string ApplicationUserId { get; set; } // Chave estrangeira para ApplicationUser
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int RecipeId { get; set; } // Chave estrangeira para Recipe
        public virtual Recipe Recipe { get; set; }
    }
}
