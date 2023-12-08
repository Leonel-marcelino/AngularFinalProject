using AngularFinalProject.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AngularFinalProject.Data


{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>    
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Favorits> Favorites { get; set; }
        public DbSet<Reviews> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar a relação entre Recipe e Category
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Category)
                .WithMany()
                .HasForeignKey(r => r.CategoryId);

            // Configurar a relação entre Recipe e Ingredient
            modelBuilder.Entity<Ingredients>()
                .HasOne(i => i.Recipe)
                .WithMany(r => r.Ingredients)
                .HasForeignKey(i => i.RecipeId);

            // Configurar a relação entre ApplicationUser, Recipe, e Favorite
            modelBuilder.Entity<Favorits>()
                .HasKey(f => new { f.ApplicationUserId, f.RecipeId });

            modelBuilder.Entity<Favorits>()
                .HasOne(f => f.ApplicationUser)
                .WithMany(u => u.Favorits)
                .HasForeignKey(f => f.ApplicationUserId);

            modelBuilder.Entity<Favorits>()
                .HasOne(f => f.Recipe)
                .WithMany(r => r.Favorites)
                .HasForeignKey(f => f.RecipeId);

            // Configurar a relação entre ApplicationUser, Recipe, e Review
            modelBuilder.Entity<Reviews>()
                .HasKey(r => new { r.ApplicationUserId, r.RecipeId });

            modelBuilder.Entity<Reviews>()
                .HasOne(r => r.ApplicationUser)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.ApplicationUserId);

            modelBuilder.Entity<Reviews>()
                .HasOne(r => r.Recipe)
                .WithMany(re => re.Reviews)
                .HasForeignKey(r => r.RecipeId);
        }
    }

}
    
