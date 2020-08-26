using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_Emp_Registration.Models
{
    public class EmpModel
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public string Date_of_birth { get; set; }
        public string Designation { get; set; }
        public string Email_Id { get; set; }
        public string Password { get; set; }
        public string c_password { get; set; }
        public string Status { get; set; }
    }
}