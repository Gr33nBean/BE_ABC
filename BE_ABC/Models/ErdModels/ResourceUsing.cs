﻿using BE_ABC.ConstValue;
using BE_ABC.Models.ErdModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        public string borrowerUid { get; set; }
        public int startAt { get; set; }
        public int endAt { get; set; }
        public int createAt { get; set; }
        public int updateAt { get; set; }
        public StatusType status { get; set; }
        [ForeignKey("reporterUid")]
        public User Reporter { get; set; }
        [ForeignKey("borrowerUid")]
        public User Borrower { get; set; }
        [ForeignKey("resourceId")]
        public Resource Resource { get; set; }
        
    }
}
