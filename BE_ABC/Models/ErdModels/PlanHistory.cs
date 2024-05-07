using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("PlanHistory")]
    public class PlanHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int planId { get; set; }
        public string userId { get; set; }
        [Column(TypeName = "text")]
        public string planValue { get; set; }
        public int startDate { get; set; }
        public string skipDate { get; set; }
        public int createAt { get; set; }
        public bool isChange { get; set; }
        [ForeignKey("userId")]
        public virtual User User { get; set; }
        [ForeignKey("planId")]
        public virtual Plan Plan { get; set; }
    }
}
