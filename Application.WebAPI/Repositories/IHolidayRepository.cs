using VacanciesAPP.DTO;

namespace Application.WebAPI.Repositories
{
    public interface IHolidayRepository
    {
        public List<Holiday> GetAllHolidays();
        public void UpdateHoliday(Guid holidayId, string holidayType, DateTime startDate, DateTime endDate);
        public void DeleteHoliday(Guid holidayId);
        public void CreateHoliday(string holidayType, DateTime startDate, DateTime endDate,Guid employeeId);
    }
}
