using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }

        public string InstructorName { get; set; }

        public string EmployeeId { get; set; }

        public string Shift { get; set; }

        public string Bio { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public InstLevelGroup ILG { get; set; }
        
        public List<Classroom> Classes { get; set; }
    }
}