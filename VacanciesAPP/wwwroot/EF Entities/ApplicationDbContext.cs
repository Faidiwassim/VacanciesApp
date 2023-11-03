
namespace VacanciesAPP.wwwroot.EF_Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(string connectionString) : base(connectionString)
        {}
        
    }
}
public class ApplicationDbContextFactory : IDbContextFactory<ApplicationDbContext>
{
    private static readonly string connectionString = ConfigurationManager.ConnectionStrings["WebStore"].ConnectionString;
    private readonly ApplicationDbContext m_dbContext = new ApplicationDbContext(connectionString);

    public ApplicationDbContext Create()
    {
        return m_dbContext;
    }
}
