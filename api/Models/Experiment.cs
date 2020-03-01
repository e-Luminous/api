using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Experiment
    {
        [Key]
        public string ExperimentId { get; set; }

        public string ExperimentName { get; set; }

        public LevelGroup LevelGroup { get; set; }

        public Region Region { get; set; }

        public List<StudentEnrollment> Enr { get; set; }

        public List<ExpClass> EC { get; set; }
    }
}