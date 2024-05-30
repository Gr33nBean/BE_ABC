using System.ComponentModel.DataAnnotations;

namespace BE_ABC.Models.CommonModels
{
    public class Pagination
    {
        [Required]
        [Range(1, 99)]
        public int page { get; set; }
        [Required]
        [Range(1, 99)]
        public int limit { get; set; }
    }
}
