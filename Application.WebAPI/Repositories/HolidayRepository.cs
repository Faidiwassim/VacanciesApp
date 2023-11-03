using Application.WebAPI.Data;
using VacanciesAPP.DTO;

namespace Application.WebAPI.Repositories
{
    public class HolidayRepository : IHolidayRepository
    {
        public DataContext _context { get; set; }

        public HolidayRepository(DataContext dataContext)
        { 
        _context=dataContext;
        }
        public void CreateHoliday(string holidayType, DateTime startDate, DateTime endDate,Guid employeeId)
        {
            var NewHoliday = new Holiday()
            {
                EmployeeId = employeeId,
                HolidayId = Guid.NewGuid(),
                HolidayType = holidayType ,
                StartDate =startDate ,
                EndDate = endDate
               
            };
            _context.Add(NewHoliday);
            _context.SaveChanges();
        }

        public void DeleteHoliday(Guid holidayId)
        {
            throw new NotImplementedException();
        }

        public void UpdateHoliday(Guid holidayId, string holidayType, DateTime startDate, DateTime endDate)
        {
            using (_context)
            {
                var holday = _context.holidays.Where(x => x.HolidayId == holidayId).FirstOrDefault();

                if (holday != null)
                {
                    holday.HolidayId = holidayId;
                    holday.HolidayType = holidayType;
                    holday.StartDate = startDate;
                    holday.EndDate = endDate;
                    _context.SaveChanges();
                }
            }
        }

        public List<Holiday> GetAllHolidays()
        {
            using (_context)
            {
                var sources = _context.holidays.ToList();
                return sources;
            }
        }
    }
}
