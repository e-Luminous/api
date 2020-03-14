using System.Collections.Generic;

namespace api.Models
{
    public class InstLevelGroup
    {
        public Institution Institution { get; set; }

        public LevelGroup LevelGroup { get; set; }

        public string InstitutionId { get; set; }

        public string LevelId { get; set; }
        
        public string GroupId { get; set; }

        public ICollection<PreAuthList> PreAuthList { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
        
        public ICollection<Student> Students { get; set; }
    }
}