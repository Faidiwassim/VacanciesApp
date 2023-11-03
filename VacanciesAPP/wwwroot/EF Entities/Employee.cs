@inject HttpClient Http
namespace VacanciesAPP.wwwroot.EF_Entities
{

    [Table("T_Employee")]
    public class Employee
    {
        [Column("EmployeeID")]
        [Key]
        int EmplyeeId { get; set; }
        [Column("Name")]
        String Name { get; set; }
        [Column("Poste")]
        String Poste { get; set; }
        [Column("SoldeConges")]
        int SoldeConges { get; set; }
    }
}
