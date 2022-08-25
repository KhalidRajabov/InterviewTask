namespace InterviewTask.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname => $"{Name} {Surname}";
        public DateTime Birthdate { get; set; }
        public DateTime CreateDate { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
    
}
