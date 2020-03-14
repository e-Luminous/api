using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Level
    {
        [Key]
        public string LevelId { get; set; }

        public string LevelName { get; set; }

        public ICollection<LevelGroup> LevelGroups { get; set; }
    }
}