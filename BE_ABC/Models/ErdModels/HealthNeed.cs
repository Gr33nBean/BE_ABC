using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("HealthNeed")]
    public class HealthNeed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string userId { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public int healthNeedTypeId { get; set; }
        public int caloriesNeedPerDay { get; set; }
        [ForeignKey("healthNeedTypeId")]
        public virtual HealthNeedType HealthNeedType { get; set; }
        [ForeignKey("userId")]
        public virtual User User { get; set; }
    }
}
