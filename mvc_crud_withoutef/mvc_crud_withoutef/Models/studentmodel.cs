using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc_crud_withoutef.Models
{
    public class studentmodel
    {
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mobile { get; set; }
        public string gender { get; set; }
      
        public string dob { get; set; }
        public string caddress { get; set; }
        public string paddress { get; set; }

        public string stream { get; set; }
        public string course { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
        public string photo { get; set; }
        public string status { get; set; }
    }
}