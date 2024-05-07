using foody_be.ConstValue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int blogId { get; set; }
        public string userId { get; set; }
        public string body { get; set; }
        public string image {  get; set; }
        public int createAt { get; set; }
        public StatusType status { get; set; }
        [ForeignKey("userId")]
        public virtual User User { get; set; }
        [ForeignKey("blogId")]
        public virtual Blog Blog { get; set; }
    }
}
