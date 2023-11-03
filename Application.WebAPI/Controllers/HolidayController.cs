using Application.WebAPI.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacanciesAPP.DTO;
using VacanciesAPP.Models;

namespace Application.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayController : ControllerBase
    {
        private readonly ILogger<HolidayController> _logger;
        private IHolidayRepository _holidayRepository;

        public HolidayController(ILogger<HolidayController> logger, IHolidayRepository holidayrepo)
        {
            _logger = logger;
            _holidayRepository=holidayrepo;
        }
        [HttpGet("getAllHolidays")]
        public List<Holiday> GetAllHolidays()
        {
            return _holidayRepository.GetAllHolidays();
        }
       
        [HttpPut("updateHoliday/{holidayId}/{holidayType}/{startDate}/{endDate}")]
        public void UpdateHoliday(Guid holidayId, string holidayType, DateTime startDate ,DateTime endDate)
        {
            _holidayRepository.UpdateHoliday(holidayId, holidayType, startDate, endDate);
        }
        [HttpDelete("deleteHoliday/{employeeId}")]
        public void  DeleteHoliday(Guid holidayId)
        {
            _holidayRepository.DeleteHoliday(holidayId);
        }
        [HttpPost("createHoliday/{holidayType}/{startDate}/{endDate}/{employeeId}")]
        public void CreateEmployee(string holidayType, DateTime startDate, DateTime endDate, Guid employeeId)
        {
            _holidayRepository.CreateHoliday(holidayType,startDate,endDate,employeeId);
        }
       













    }
}
