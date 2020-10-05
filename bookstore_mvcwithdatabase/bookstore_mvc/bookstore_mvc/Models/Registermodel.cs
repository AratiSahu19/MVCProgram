using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace bookstore_mvc.Models
{
    public class Registermodel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "First_Name required")]
        public string firstname { get; set; }


        [Required(ErrorMessage = "Last_Name required")]
        public string lastname { get; set; }

        public string gender { get; set; }



        [Required(ErrorMessage = "Date of birth  required")]
        public string dob { get; set; }

        public string age { get; set; }
        [Required(ErrorMessage = "email_id required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string email { get; set; }
        [Required(ErrorMessage = "password required")]
        //[StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "password required")]
        //[StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirm_password { get; set; }

    }
}
