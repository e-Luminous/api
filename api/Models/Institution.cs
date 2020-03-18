using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace api.Models
{
    public class Institution
    {
        [Key]
        public string InstitutionId { get; set; }

        public string InstitutionName { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public string UTC { get; set; }

        public string Domain { get; set; }

        public Country Country { get; set; }

        public IdentityUser Users { get; set; }
        
        public ICollection<Subscription> Subscribed { get; set; }
        public ICollection<InstLevelGroup> InstLevelGroup { get; set; }
    }
}