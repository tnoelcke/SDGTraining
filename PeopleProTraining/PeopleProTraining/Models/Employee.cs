using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace PeopleProTraining.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set;}
    }
}