using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleProTraining.Models
{
    public class Building
    {
        public int ID { set; get; }
        [Display(Name = "Building Name")]
        public string name { set; get; }
        [Display(Name = "Room Number")]
        public int number { set; get; }
        [Display(Name = "Address")]
        public string address { set; get; }
    }
}