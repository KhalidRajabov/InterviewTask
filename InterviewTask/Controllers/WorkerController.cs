using AutoMapper;
using AutoMapper.QueryableExtensions;
using InterviewTask.DAL;
using InterviewTask.DTO.EmployeeDTO;
using InterviewTask.Extension;
using InterviewTask.Helper;
using InterviewTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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

        /// <summary>
        /// Filter Get method
        /// </summary>
        /// <param name="pageFilter"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="depid"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ICollection<Employee>>> GetFilteredEmployees([FromQuery] FilterEmployeeDTO f)
        {

            var employees = _context.Employees.AsQueryable();
            if (f.Id != 0)
            {
                employees = employees.Where(e => e.Id == f.Id);
            }
            if (f.Name != null)
            {
                employees = employees.Where(e => e.Name.ToLower().Contains(f.Name.ToLower()));
            }
            if (f.Surname != null)
            {
                employees = employees.Where(e => e.Surname.ToLower().Contains(f.Surname.ToLower()));
            }
            if (f.DepartmentId != 0)
            {
                employees = employees.Where(e => e.DepartmentId == f.DepartmentId);
            }

            var pagedList = await PageList<Employee>.CreateAsync(employees, f.pageFilter.PageNumber, f.pageFilter.PageSize);
            Response.AddPaginationHeader(pagedList.CurrentPage, pagedList.PageSize, pagedList.TotalCount, pagedList.TotalPages);

            return pagedList.ToList();
        }



        [HttpGet("ALlWithDetails")]
        public ALlEmployeeListDTO GetAllEmployees()
        {
            
            var query = _context.Employees.Include(d => d.Department).AsQueryable();
            List<AllEmployeeDTO> employeereturn = _mapper.Map<List<AllEmployeeDTO>>(query.ToList());
            ALlEmployeeListDTO employeeListDTO = _mapper.Map<ALlEmployeeListDTO>(employeereturn);
            return employeeListDTO;
        }

        [HttpGet("{id}")]
        public  IActionResult GetOne(int? id)
        {
            if (id == null) return StatusCode(404, "Id is incorrect");
            Employee employee =  _context.Employees.Include(d=>d.Department).FirstOrDefault(p=>p.Id==id);
            if (employee == null) return StatusCode(404, $"Employee with the id of {id} does not exist");
            EmployeeReturnDTO employeeReturn = _mapper.Map<EmployeeReturnDTO>(employee);
            return StatusCode(200, employeeReturn);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeCreateDTO? DTO)
        {
            if (DTO == null) return StatusCode(404,"Incorrect action");
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
        public async Task<IActionResult> UpdateEmployee(int? id, EmployeeUpdateDTO dto)
        {
            if (id == null) return StatusCode(404, "Id is incorrect");
            Employee employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null) return StatusCode(404, $"User with the id {id} not found");
            employee.Name = dto.Firstame;
            employee.Surname = dto.Surname;
            employee.Birthdate = dto.Birthdate;
            employee.DepartmentId = dto.DepartmentId;
            await _context.SaveChangesAsync();
            return StatusCode(200, $"{employee.Fullname} updated");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int? id)
        {
            if (id == null) return StatusCode(404, "Inocrrect id");
            Employee employee = await _context.Employees.FindAsync(id);
            if (employee == null) return StatusCode(404, $"User with the id {id} not found");
            _context.Remove(employee);
            _context.SaveChanges();
            return Ok($"{employee.Name} deleted");
        }
    }
}