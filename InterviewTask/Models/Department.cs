namespace InterviewTask.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
