using BE_ABC.ConstValue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_ABC.Models.ErdModels
{
    [Table("ResourceUsing")]
    public class ResourceUsing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int resourceId { get; set; }
        public string reporterUid { get; set; }
        public string borroerUid { get; set; }
        public int startAt { get; set; }
        public int endAt { get; set; }
        public int createAt { get; set; }
        public int updateAt { get; set; }
        public StatusType status { get; set; }
    }
}
