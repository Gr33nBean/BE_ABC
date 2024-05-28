﻿using BE_ABC.ConstValue;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_ABC.Models.DTO.Request
{
    public class EventReq
    {
        public int id { get; set; }
        public string eventTypeId { get; set; }
        public string reporterUid { get; set; }
        public List<int> resouceUsingId { get; set; }
        public List<int> postsId { get; set; }
        public List<string> paticipantsUid { get; set; }
        public List<Grade> permissionIdToCRUDPost { get; set; }
        public string name { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public int startAt { get; set; }
        public int endAt { get; set; }
        public StatusType status { get; set; }
    }
}
