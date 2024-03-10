using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Entities
{
    public class Students
    {
        [Key]
        public Guid StudentID { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; } = String.Empty;
        [MaxLength(50)]
        public string LastName { get; set; } = String.Empty;
        [MaxLength(50)]
        public string? MiddleName { get; set; } = String.Empty;
        [MaxLength(250)]
        public string? Address { get; set; } = String.Empty;
        [MaxLength(12)]
        public string? PhoneNumber { get; set; } = String.Empty;
        [MaxLength(50)]
        public string? Email { get; set; } = String.Empty;
        public int? StudentLevel { get; set; }
        public string? StudentImg {  get; set; } = string.Empty;
        public ICollection<StudentSubjects>? StudentSubjects { get; set; }
    }
}
