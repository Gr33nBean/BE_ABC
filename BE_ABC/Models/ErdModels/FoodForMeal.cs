using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("FoodForMeal")]
    public class FoodForMeal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int mealPlanId { get; set; }
        public int recipeId { get; set; }
        [Column(TypeName = "text")]
        public string recipeVulue { get; set; }
        [ForeignKey("mealPlanId")]
        public virtual MealPlan MealPlan { get; set; }
        [ForeignKey("recipeId")]
        public virtual Recipe Recipe { get; set; }
    }
}
