using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacanciesAPP.DTO
{
    [Table("Holiday")]
    public class Holiday
    {
        [Key]
        public Guid HolidayId { get; set; }
        [Column("Holiday type")]
        [Required]
        public string HolidayType { get; set; }
        [Column("Start Date")]
        [Required]
        public DateTime StartDate { get; set; }
        [Column("End Date")]
        [Required]
        public DateTime EndDate { get; set; }
        [Column("EmployeeId")]
        [Required]
        public Guid EmployeeId { get; set; }

        public Holiday(){}
        public Holiday(Guid holidayId,string holidayType,DateTime startDate, DateTime endDate,Guid employeeID)
        {
          EmployeeId = employeeID;
          HolidayId =holidayId;
          HolidayType=holidayType;
          StartDate=startDate;
          EndDate=endDate;
         
        }
    }

}
