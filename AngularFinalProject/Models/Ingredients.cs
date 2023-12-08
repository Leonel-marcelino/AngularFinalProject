namespace AngularFinalProject.Models
{
    public class Ingredients
    {
        public Guid IngredientId { get; set; }
        public string Name { get; set; }

        public string QuantityIngredient { get; set; }

        public int RecipeId { get; set; } // Chave estrangeira para Recipe
        public virtual Recipe Recipe { get; set; }
    }
}
