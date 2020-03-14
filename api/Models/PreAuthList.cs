using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class PreAuthList
    {
        [Key]
        public string PreAuthId { get; set; }
        public string Mail { get; set; }
        public InstLevelGroup InstLevelGroup { get; set; }
    }
}