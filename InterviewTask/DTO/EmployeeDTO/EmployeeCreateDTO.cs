namespace InterviewTask.DTO.EmployeeDTO
{
    public class EmployeeCreateDTO
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime CreatedTime { get; set; }
        public int DepartmentId { get; set; }

    }
}
