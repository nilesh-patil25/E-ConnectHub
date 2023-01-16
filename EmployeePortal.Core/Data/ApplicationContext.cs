using CRUDOPERATION.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOPERATION.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
