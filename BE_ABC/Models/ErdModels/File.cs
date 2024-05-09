using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_ABC.Models.ErdModels
{ 
    public class Files
    {
        public string url { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int size { get; set; }
    }
}
