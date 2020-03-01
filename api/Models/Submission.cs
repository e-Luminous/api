using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Submission
    {
        [Key]
        public string SubmissionId { get; set; }

        public string ObservationJSON { get; set; }

        public double MarksGiven { get; set; }

        public string Status { get; set; }

        public ExpClass ExpClass { get; set; }

        public Student Student { get; set; }
    }
}