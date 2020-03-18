using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace api.Models
{
    public class Instructor
    {
        [Key]
        public string InstructorId { get; set; }

        public string InstructorName { get; set; }

        public string EmployeeId { get; set; }

        public string Shift { get; set; }

        public string Bio { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public IdentityUser Users { get; set; }
        
        public InstLevelGroup InstLevelGroup { get; set; }
        
        public List<Classroom> Classes { get; set; }
    }
}