namespace InterviewTask.DTO.EmployeeDTO
{
    public class EmployeeCreateDTO
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime CreatedTime { get; set; }
        public int DepartmentId { get; set; }

    }
}
