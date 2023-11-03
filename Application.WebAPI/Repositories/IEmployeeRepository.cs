using VacanciesAPP.Models;

namespace Application.WebAPI.Repositories
{
    public interface IEmployeeRepository
    {
        public Employee getEmployeeById(Guid employeeId);
        public double getVacancyDayNumbers(Guid employeeId);
        public List<Employee> getAllEmployees();
        public void updateEmployee(Guid employeeId,string name, string jobDescription, int totalVacancyDays);
        public void deleteEmployee(Guid employeeId);
        public void createEmployee(string name, string jobDescription,int totalVacancyDays);
    }
}
