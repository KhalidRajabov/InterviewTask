
using InterviewTask.DTO;

namespace InterviewTask.Filter
{
    public class Filtering
    {
        public FilterEmployees Filter { get; set; }
    }

    public enum FilterEmployees
    {
        A_Z = 1,
        Z_A,
        Age,
        Joined
    }
}
