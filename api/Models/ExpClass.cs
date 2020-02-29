using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class ExpClass
    {
        [Key]
        public string ExperimentId { get; set; }

        public string ClassroomId { get; set; }

        public double MarksScale { get; set; }

        public bool IsPrivate { get; set; }

        public List<Submission> Subs { get; set; }

        public Experiment Experiment { get; set; }

        public Classroom Classroom { get; set; }
    }
}