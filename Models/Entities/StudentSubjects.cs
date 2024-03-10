using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrollmentSystem.Models.Entities
{
    public class StudentSubjects
    {
        [Key]
        public Guid StudentSubjectID { get; set; }

        [ForeignKey("Students")]
        public Guid StudentID { get; set; }
        public Students Students { get; set; }

        [ForeignKey("Subjects")]
        public Guid SubjectID { get; set; }
        public Subjects Subjects { get; set; }
    }
}
