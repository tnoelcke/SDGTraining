namespace PeopleProTraining.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using PeopleProTraining.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleProTraining.DAL.CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PeopleProTraining.DAL.CompanyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var employees = new List<Employee>
            {
                new Employee { firstName ="Thoams", lastName = "Noelcke", DepartmentID = 0 },
                new Employee { firstName = "Bob", lastName = "Collier", DepartmentID = 1 },
                new Employee {firstName = "Liz", lastName = "Miller", DepartmentID = 2 },
                new Employee {firstName = "Nikita", lastName = "Noelcket", DepartmentID = 3 }

            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department {ID = 0, name = "Software", BuildingID = 0 },
                new Department {ID = 1, name = "Civil Engineering", BuildingID = 1},
                new Department {ID = 2, name = "Graphic Design", BuildingID = 2 },
                new Department {ID = 3, name = "Teaching", BuildingID = 3 }
            };

            departments.ForEach(s => context.Departments.Add(s));

            var buildings = new List<Building>
            {
                new Building {ID = 0, name = "Engineering Office", number = 122, address = "35110 Some Place" },
                new Building {ID = 1, name = "Engineering Offivce", number = 123, address = "35110 Some Place" },
                new Building {ID = 2, name = "Graphic Design Center", number = 100, address = "35000 maple Place" },
                new Building {ID = 3, name = "Middle School", number = 100, address = "2001 Staton BLVD" }
            };

            buildings.ForEach(s => context.Buildings.Add(s));
            context.SaveChanges();
        }
    }
}
