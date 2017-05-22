using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PeopleProTraining.Models;

namespace PeopleProTraining.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyContext") {
        }

        public DbSet<Employee> Employees { set; get; }
        public DbSet<Department> Departments { set; get; }
        public DbSet<Building> Buildings { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        } 
    }
}