namespace VacanciesAPP.Models
{
    public class Employee
    {
        Guid EmplyeeId { get; set; }
        String Name { get; set; }
        public String JobPosition { get; set; }
        int VacancyDays { get; set; }
        public Employee(String name,String jobPosition,int vacancyDays)
        {
            EmplyeeId = Guid.NewGuid();
            Name = name;
            JobPosition = jobPosition;
            VacancyDays = vacancyDays;
        }
    }
   
}
