using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VacanciesAPP.DTO;



namespace VacanciesAPP.Models
{
    [Table("Employee")]
    public class Employee 
    {
        [Key]
        public Guid EmployeeId { get; set; }
        [Column("Name")]
        [Required]
        public string Name { get; set; }
        [Column("JobPosition")]
        [Required]
        public string JobPosition { get; set; }
        [Column("TotalVacancyDays")]
        [Required]
        public int TotalVacancyDays { get; set; }
        //[Column("RestVacancyDays")]
        //[Required]
        //public int RestVacancyDays { get; set; }

        [Column("Holidays")]
        public virtual ICollection<Holiday>? HolidaysList { get; set; }
        public Employee(){}
        public Employee(Guid emplyeeId, string name,string jobPosition,int totalVacancyDays,List<Holiday> holidaysList)
        {
            EmployeeId = emplyeeId;
            Name = name;
            JobPosition = jobPosition;
            TotalVacancyDays = totalVacancyDays;
           // RestVacancyDays = restVaacancyDays;
            HolidaysList= holidaysList;
        }

        //public async int GetRestDD() 
        //{
        //    int x= await Http.GetFromJsonAsync<int>($"https://localhost:7258/api/Vacancy/GetVacancyDays");
        //    return 1;
        //}


    }
   
}
