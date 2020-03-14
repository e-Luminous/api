using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class LevelGroup
    {
        public string LevelId { get; set; }

        public string GroupId { get; set; }

        public double Price { get; set; }

        public Level Level { get; set; }

        public Group Group { get; set; }

        public ICollection<InstLevelGroup> InstLevelGroups { get; set; }

        public ICollection<Experiment> Exps { get; set; }
    }
}