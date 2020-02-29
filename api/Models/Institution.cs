using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Institution
    {
        [Key]
        public int InstitutionId { get; set; }

        public string InstitutionName { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public TimeZone UTC { get; set; }

        public string Domain { get; set; }

        public Country Country { get; set; }

        public ICollection<Subscription> Subscribed { get; set; }
        
        public ICollection<InstLevelGroup> ILG { get; set; }
    }
}