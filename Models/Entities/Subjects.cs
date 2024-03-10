using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Entities
{
    public class Subjects
    {
        [Key]
        public Guid SubjectId { get; set; }
        public string SubjectCode { get; set; } = string.Empty;
        public string SubjectName { get; set; } = string.Empty;
        public string SubjectDescription { get; set; } = string.Empty;
        public bool IsActive { get; set; }

    }
}
