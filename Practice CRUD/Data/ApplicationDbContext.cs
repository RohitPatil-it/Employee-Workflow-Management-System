using Microsoft.EntityFrameworkCore;
using Practice_CRUD.Models;

namespace Practice_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Emp> emps { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }
       
    }
}
