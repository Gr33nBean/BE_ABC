using foody_be.Models.ErdModels;
using Microsoft.EntityFrameworkCore;

namespace foody_be.Models.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        #region DbSet
        public DbSet<HealthNeedType> HealthNeedType { get; set; }
        public DbSet<HealthNeed> HealthNeed { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Diet> Diet { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<PlanHistory> PlanHistory { get; set; }
        public DbSet<DayPlan> DayPlan { get; set; }
        public DbSet<RecipeDirection> RecipeDirection { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredient { get; set; }
        public DbSet<MealPlan> MealPlan { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<FoodForMeal> FoodForMeal { get; set; }
        public DbSet<Nutrition> Nutrition { get; set; }
        public DbSet<IngredientType> IngredientType { get; set; }
        #endregion

        #region model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
