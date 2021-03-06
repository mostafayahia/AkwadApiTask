using Microsoft.EntityFrameworkCore;

namespace AkwadApiTask.Models
{
    public class AkwadTaskContext : DbContext
    {
        public AkwadTaskContext(DbContextOptions<AkwadTaskContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
