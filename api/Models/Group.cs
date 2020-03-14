using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Group
    {
        [Key]
        public string GroupId { get; set; }

        public string GroupName { get; set; }
        
        public ICollection<LevelGroup> LevelGroups { get; set; }
    }
}