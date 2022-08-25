namespace InterviewTask.DTO.EmployeeDTO
{
    public class EmployeeReturnDTO
    {
        public string? Fullname { get; set; }
        public string? Birthdate { get; set; }
        public string? Joined { get; set; }
        public EmployeeDepartmentDTO? Department { get; set; }
    }

    public class EmployeeDepartmentDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
