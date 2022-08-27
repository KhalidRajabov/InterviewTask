using InterviewTask.Helper;

namespace InterviewTask.DTO.EmployeeDTO
{
    public class FilterEmployeeDTO
    {
        public int Id { get; set; } = 0;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }
        public int DepartmentId { get; set; }
        public PageFilter pageFilter { get; set; }
    }
}
