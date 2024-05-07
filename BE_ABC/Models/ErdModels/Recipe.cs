using foody_be.ConstValue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("Recipe")]
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string userId { get; set; }
        public string name { get; set; }
        public int totalTime { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        [Column(TypeName = "text")]
        public string image { get; set; }
        public int nutritionId { get; set; }
        public int createAt { get; set; }
        public bool isPublic { get; set; }
        public StatusType status { get; set; }
    }
}
