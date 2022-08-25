using AutoMapper;
using InterviewTask.DAL;
using InterviewTask.DTO.EmployeeDTO;
using InterviewTask.Filter;
using InterviewTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterviewTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public WorkerController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
 
      /*  [HttpGet("Filter")]
        public List<EmployeeReturnDTO> Filter([FromQuery] Filtering filter)
        {
            
            List<EmployeeReturnDTO> employeeReturnDTOs = new List<EmployeeReturnDTO>();
            var query = _context.Employees.AsQueryable();

            switch (filter.Filter)
            {
                case FilterEmployees.A_Z:
                    employeeReturnDTOs = query.Select(e => new EmployeeReturnDTO
                    {
                        Fullname = e.Fullname,
                        Joined = e.CreateDate.ToString("MM/dd/yyyy"),
                        Birthdate = e.CreateDate.ToString("MM/dd/yyyy")
                    }).ToList();
                    break;
                case FilterEmployees.Age:
                    break;
                case FilterEmployees.Joined:
                    break;
                default:
                    break;
            }


            return employeeReturnDTOs;
        }
*/
        [HttpGet("ALlWithDetails")]
        public EmployeeListDTO GetAllEmployees()
        {
            
            var query = _context.Employees.Include(d => d.Department).AsQueryable();

            List<EmployeeReturnDTO> employeereturn = _mapper.Map<List<EmployeeReturnDTO>>(query.ToList());
            EmployeeListDTO employeeListDTO = _mapper.Map<EmployeeListDTO>(employeereturn);
            return employeeListDTO;
        }

        [HttpGet("{id}")]
        public  IActionResult GetOne(int id)
        {
            Employee employee =  _context.Employees.Include(d=>d.Department).FirstOrDefault(p=>p.Id==id);
            if (employee == null) return StatusCode(404, $"Employee with the id of {id} does not exist");
            EmployeeReturnDTO employeeReturn = _mapper.Map<EmployeeReturnDTO>(employee);
            return StatusCode(200, employeeReturn);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeCreateDTO DTO)
        {
            Employee employee = new Employee()
            {
                Name = DTO.Firstname,
                Surname = DTO.Lastname,
                Birthdate = DTO.Birthdate,
                CreateDate = DTO.CreatedTime,
                DepartmentId = DTO.DepartmentId
            };
            await _context.AddAsync(employee);
            await _context.SaveChangesAsync();

            return StatusCode(201, $"{DTO.Firstname} added to database");
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeUpdateDTO dto)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            employee.Name = dto.Firstame;
            employee.Surname = dto.Surname;
            employee.Birthdate = dto.Birthdate;
            employee.DepartmentId = dto.DepartmentId;
            await _context.SaveChangesAsync();
            return StatusCode(200, $"{employee.Fullname} updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            Employee employee = await _context.Employees.FindAsync(id);
            _context.Remove(employee);
            _context.SaveChanges();
            return Ok($"{employee.Name} deleted");
        }
    }
}