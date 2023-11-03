using Microsoft.EntityFrameworkCore;
using VacanciesAPP.DTO;
using VacanciesAPP.Models;

namespace Application.WebAPI.Data
{
    public class DataContext:DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Employee> employees{get;set;}
        public DbSet<Holiday> holidays { get; set;}
    }
}
