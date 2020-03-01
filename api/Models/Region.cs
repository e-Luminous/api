using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }

        public string RegionName { get; set; } 

        public ICollection<Country> Countries { get; set; }
        
        public ICollection<Experiment> Exps { get; set; }
    }
}