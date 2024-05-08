﻿using BE_ABC.ConstValue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_ABC.Models.ErdModel
{
    [Table("Resource")]
    public class Resource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int resourceTypeId { get; set; }
        public string name { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public bool isFree { get; set; }
        public int createAt { get; set; }
        public int updateAt { get; set; }
        public StatusType status { get; set; }
    }
}