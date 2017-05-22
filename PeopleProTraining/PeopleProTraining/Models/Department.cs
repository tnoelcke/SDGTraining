using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleProTraining.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string name { set; get; }
        [ForeignKey("Building")]
        public int BuildingID { set; get; }
        public virtual Building Building { set; get; }
    }
}