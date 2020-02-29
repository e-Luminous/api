using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }

        public string ClassroomTitle { get; set; }

        public string AccessCode { get; set; }

        public string IllustrationUrl { get; set; }

        public string Theme { get; set; }

        public InstLevelGroup ILG { get; set; }

        public Instructor Instructor { get; set; }

        public List<StudentEnrollment> Enr { get; set; }
        
        public List<ExpClass> EC { get; set; }
    }
}