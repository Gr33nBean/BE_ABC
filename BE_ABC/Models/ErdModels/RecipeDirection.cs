using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("RecipeDirection")]
    public class RecipeDirection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int recipeId { get; set; }
        public int order {  get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        [Column(TypeName = "text")]
        public string image { get; set; }
        [ForeignKey("recipeId")]
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
