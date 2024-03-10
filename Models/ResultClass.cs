using System.Text.Json;

namespace EnrollmentSystem.Models
{
    public class ResultClass
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        //public override string ToString()
        //{
        //    return JsonSerializer.Serialize(this);
        //}
    }
}
