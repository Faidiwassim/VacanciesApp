using Application.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using VacanciesAPP.Models;

namespace Application.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private IEmployeeRepository _calculateVacancy;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeRepository calculateVacancy)
        {
            _logger = logger;
            _calculateVacancy = calculateVacancy;
        }


        [HttpGet("getEmployeeById/{employeeId}")]
        public Employee getEmployeeById(Guid employeeId)
        { 
        return  _calculateVacancy.getEmployeeById(employeeId);
        }


        [HttpGet("GetVacancyDays/{employeeId}")]
        public double getVacancyDayNumbers(Guid employeeId)
        {
            return _calculateVacancy.getVacancyDayNumbers(employeeId);
        }

        [HttpGet("getAllEmployees")]
        public List<Employee> getAllEmployees()
        {
            return _calculateVacancy.getAllEmployees();
        }

        [HttpPut("updateEmployee/{employeeId}/{name}/{jobDescription}/{totalVacancyDays}/{restVacancyDays}")]
        public void updateEmployee(Guid employeeId, string name, string jobDescription, int totalVacancyDays, int restVacancyDays)
        {
            _calculateVacancy.updateEmployee(employeeId, name, jobDescription, totalVacancyDays);
        }
        [HttpDelete("deleteEmployee/{employeeId}")]
        public void deleteEmployee(Guid employeeId)
        {
            _calculateVacancy.deleteEmployee(employeeId);
        }
        [HttpPost("createEmployee/{name}/{jobDescription}/{totalVacancyDays}")]
        public void createEmployee(string name, string jobDescription, int totalVacancyDays, int restVacancyDays)
        {
            _calculateVacancy.createEmployee(name, jobDescription, totalVacancyDays);
        }


    }
}
