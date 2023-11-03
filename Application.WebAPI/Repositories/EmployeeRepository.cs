using Application.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using VacanciesAPP.DTO;
using VacanciesAPP.Models;

namespace Application.WebAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DataContext _context;


        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }


        public Employee getEmployeeById(Guid employeeId) {
            using (_context)
            {
                var employee = _context.employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
                if (employee !=null)
                    return employee;
                else return null;
            }
            
        }
        public double getVacancyDayNumbers(Guid employeeId)
        {
             double somme=0;
            using (_context)
            {
              List<Holiday> HolidayList=_context.holidays.Where(h => h.EmployeeId == employeeId).ToList();
                foreach (var x in HolidayList)
                {
                    somme+=  (x.EndDate - x.StartDate).TotalDays;
                }
               
            }
            return somme;
        }
        public List<Employee> getAllEmployees()
        {
            using (_context)
            {
                var sources = _context.employees.ToList();
                return sources;
            }

        }

        void IEmployeeRepository.updateEmployee(Guid employeeId, string name, string jobDescription, int totalVacancyDays)
        {
            using (_context)
            {
                var employee = _context.employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();

                if (employee != null)
                {
                    employee.Name = name;
                    employee.JobPosition = jobDescription;
                    employee.TotalVacancyDays = totalVacancyDays;
                   // employee.RestVacancyDays = restVacancyDays;
                    _context.SaveChanges();
                }
            }
        }

        void IEmployeeRepository.deleteEmployee(Guid employeeId)
        {
            var employee = _context.employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
            if (employee != null)
            {
                _context.Remove(employee);
                _context.SaveChanges();
            }
        }

        void IEmployeeRepository.createEmployee(string name, string jobDescription, int totalVacancyDays)
        {
            var NewEmployee = new Employee()
            {
                EmployeeId = Guid.NewGuid(),
                Name = name,
                JobPosition = jobDescription,
                TotalVacancyDays = totalVacancyDays,
              //  RestVacancyDays = restVacancyDays
            };
            _context.Add(NewEmployee);
            _context.SaveChanges();
        }
    }
}
