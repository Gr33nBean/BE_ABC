using foody_be.ConstValue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int planId { get; set; }
        public string userId { get; set; }
        [Column(TypeName = "text")]
        public string title { get; set; }
        [Column(TypeName = "text")]
        public string body { get; set; }
        public string image {  get; set; }
        public int createAt { get; set; }
        public int heart {  get; set; }
        public int clone { get; set; }
        public bool isPublic { get; set; }
        public StatusType status { get; set; }
        [ForeignKey("userId")]
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        [ForeignKey("planId")]
        public virtual Plan Plan { get; set; }
    }
}
