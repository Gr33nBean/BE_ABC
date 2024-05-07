 using foody_be.ConstValue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{

    [Table("Diet")]
    public class Diet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string userId { get; set; }
        public string name { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public int planLenght { get; set; }
        public int createAt { get; set; }
        public bool isPublic { get; set; }
        public StatusType status { get; set; }
        [ForeignKey("userId")]
        public virtual User User { get; set; }
        public virtual ICollection<Plan> Plan { get; set; }
    }
}
