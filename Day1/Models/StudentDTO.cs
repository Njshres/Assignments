namespace Student_Management.Models
{
    public class StudentDTO
    {
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
