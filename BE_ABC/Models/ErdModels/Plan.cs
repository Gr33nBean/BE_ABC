using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int dietId { get; set; }
        public string name { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public int dayPlanLenght { get; set; }
        public int createAt { get; set; }
        public bool isPublic { get; set; }
        public int nutritionId { get; set; }
        [ForeignKey("dietId")]
        public virtual Diet Diet { get; set; }
        public virtual ICollection<Blog> Blog { get; set; }
        public virtual ICollection<DayPlan> DayPlan { get; set; }
        public virtual ICollection<PlanHistory> PlanHistory { get; set; }
    }
}
