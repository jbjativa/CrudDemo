using System.Collections.Generic;
using System;
using CrudDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace CrudDemo.Data
{
    public class CrudDemoContext : DbContext
    {

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public CrudDemoContext(DbContextOptions<CrudDemoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var company = LoadCompany();
            var departments = LoadDepartments(company);
            var employees = LoadEmployees(departments);

            modelBuilder.Entity<Company>().HasData(company);
            modelBuilder.Entity<Department>().HasData(departments.ToArray());
            modelBuilder.Entity<Employee>().HasData(employees.ToArray());

        }

        private List<Employee> LoadEmployees(List<Department> departments)
        {
            var employeeList = new List<Employee>();
            Random rnd = new Random();

            foreach (var dept in departments)
            {
                int cantRandom = rnd.Next(5, 10);
                var empTempList = GenerateEmployees(dept, cantRandom);
                employeeList.AddRange(empTempList);
            }
            return employeeList;
        }

        private List<Employee> GenerateEmployees(Department dept, int cantRandom)
        {
            string[] name = { "Angelina", "Andrea", "Carol", "Nicol" };
            string[] lastName = { "Holland", "Stark", "Trump", "Biden" };
            string[] sname = { "Anabel", "Murtina", "Silvana", "Persephone" };

            var employeeList = from n1 in name
                               from n2 in sname
                               from n3 in lastName
                               select new Employee { Name = $"{n1} {n2} {n3}", DepartmentId = dept.Id };

            return employeeList.OrderBy((emp) => emp.Id).Take(cantRandom).ToList();
        }

        private List<Department> LoadDepartments(Company company)
        {
            return new List<Department>()
           {
               new Department{Name="Backoffice", CompanyId= company.Id},
               new Department{Name="Sales", CompanyId= company.Id}
           };
        }

        private Company LoadCompany()
        {
            var company = new Company();
            company.Name = "Crud Company";
            company.Country = "Ecuador mi pais";
            company.State = "Guayas";
            company.City = "Guayaquil";
            company.Address = "9 de Octubre y Boyaca";
            return company;
        }
    }
}