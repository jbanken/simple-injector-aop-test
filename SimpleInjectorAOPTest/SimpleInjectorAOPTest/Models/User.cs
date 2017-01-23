using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleInjectorAOPTest.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TypeID { get; set; }
    }
}