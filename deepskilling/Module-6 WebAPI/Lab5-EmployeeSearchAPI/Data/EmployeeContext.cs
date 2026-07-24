using Lab5_EmployeeSearchAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5_EmployeeSearchAPI.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}