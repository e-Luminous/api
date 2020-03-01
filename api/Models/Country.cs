using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public Region Region { get; set; }
        
        public ICollection<Institution> Institutions { get; set; }
    }
}