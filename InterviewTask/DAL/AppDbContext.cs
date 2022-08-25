using InterviewTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace InterviewTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }


        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Department>? Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name="Khalid",
                    Surname = "Rajabov",
                    Birthdate = DateTime.Now,
                    CreateDate = DateTime.Now,
                    DepartmentId = 1
                }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 2,
                    Name = "Felix",
                    Surname = "Paw",
                    Birthdate = DateTime.Now,
                    CreateDate = DateTime.Now,
                    DepartmentId = 1
                }
                );
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    Name = "Developers",
                    CreateDate = DateTime.Now
                }
                );
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 2,
                    Name = "HR Manager",
                    CreateDate = DateTime.Now
                }
                );
        }
    }
}
