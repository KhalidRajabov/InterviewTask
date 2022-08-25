using AutoMapper;
using InterviewTask.DTO;
using InterviewTask.DTO.EmployeeDTO;
using InterviewTask.Models;

namespace InterviewTask.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EmployeeReturnDTO>()
                .ForMember(e => e.Fullname, map => map.MapFrom(d => d.Fullname))
                .ForMember(e => e.Birthdate, map => map.MapFrom(d => d.Birthdate))
                .ForMember(e => e.Joined, map => map.MapFrom(d => d.CreateDate.ToString("MM/dd/yyyy")));
            CreateMap<Department, EmployeeDepartmentDTO>().ReverseMap();
            CreateMap<List<EmployeeReturnDTO>, EmployeeListDTO>()
                .ForMember(d => d.Employees, map => map.MapFrom(s => s.Count))
                .ForMember(d => d.Workers, map => map.MapFrom(s => s));
        }
    }
}
