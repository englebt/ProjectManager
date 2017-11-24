using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Models
{
    public class PMContext : DbContext
    {
        public PMContext(DbContextOptions<PMContext> options) : base(options)
        { 
            DbInit.Init(this);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks{ get; set; }
    }

    public static class DbInit
    {
        public static void Init(PMContext db)
        {
            db.Database.EnsureCreated();
            if (db.Projects.Any())
                return; // Database already created

            Project[] projects = new Project[2];
            Project proj1 = new Project() { Name = "Project 1", ContractValue = 1000000, FundingValue = 500000 };
            Project proj2 = new Project() { Name = "Project 2", ContractValue = 1000000, FundingValue = 500000 };
            projects[0] = proj1;
            projects[1] = proj2;

            Task p1t1 = new Task() { Name = "Proj1, Task 1", FundingValue = 250000 };
            Task p1t2 = new Task() { Name = "Proj1, Task 2", FundingValue = 250000 };
            Task p2t1 = new Task() { Name = "Proj2, Task 1", FundingValue = 250000 };
            Task p2t2 = new Task() { Name = "Proj2, Task 2", FundingValue = 250000 };
            projects[0].Tasks.Add(p1t1);
            projects[0].Tasks.Add(p1t2);
            projects[1].Tasks.Add(p2t1);
            projects[1].Tasks.Add(p2t2);

            Employee emp1 = new Employee() { Name = "Employee 1"};
            Employee emp2 = new Employee() { Name = "Employee 2"};
            Employee emp3 = new Employee() { Name = "Employee 3"};
            Employee emp4 = new Employee() { Name = "Employee 4"};
            
            proj1.Manager = emp1;
            p1t1.Manager = emp1;
            p1t2.Manager = emp1;
            proj1.Employees.AddRange(new Employee[] { emp1, emp2 });
            proj1.Employees.AddRange(new Employee[] { emp1, emp2 });
            p1t1.Employees.AddRange(new Employee[] { emp1, emp2 });
            p1t2.Employees.AddRange(new Employee[] { emp1, emp2 });

            proj2.Manager = emp4;
            p2t1.Manager = emp4;
            p2t2.Manager = emp4;
            proj2.Employees.AddRange(new Employee[] { emp1, emp2 });
            proj2.Employees.AddRange(new Employee[] { emp1, emp2 });
            p2t1.Employees.AddRange(new Employee[] { emp3, emp4 });
            p2t2.Employees.AddRange(new Employee[] { emp3, emp4 });

            db.Projects.AddRange(projects);
            db.SaveChanges();
        }
    }
}
