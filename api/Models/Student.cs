using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string InstitutionId { get; set; }

        public string Shift { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public InstLevelGroup ILG { get; set; }
        
        public List<StudentEnrollment> Enr { get; set; }

        public List<Submission> Subs { get; set; }
    }
}