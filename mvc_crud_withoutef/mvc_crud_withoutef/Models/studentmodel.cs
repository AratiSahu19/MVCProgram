using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace mvc_crud_withoutef.Models
{
    public class studentmodel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First_Name required")]
        public string firstname { get; set; }


        [Required(ErrorMessage = "Last_Name required")]
        public string lastname { get; set; }


        public string mobile { get; set; }
        [Required(ErrorMessage = "mobile no required")]
        public string gender { get; set; }


        [Required(ErrorMessage = "Date of birth  required")]
        public string dob { get; set; }
        [Required(ErrorMessage = "coresspondence Address required")]
        public string caddress { get; set; }

        [Required(ErrorMessage = "permanent Address required")]
        public string paddress { get; set; }
        [Required(ErrorMessage = "stream required")]
        public Stream stream { get; set; }
        [Required(ErrorMessage = "course required")]
        public string course { get; set; }
        [Required(ErrorMessage = "email_id required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string email { get; set; }

        public string password { get; set; }
        public string confirm_password { get; set; }
        [DisplayName("Upload Image")]
        public string photo { get; set; }
        public bool status { get; set; }
        public string streamp { get; set; }
        public HttpPostedFileBase ImageFile {get;set;}
    }
    public enum Stream
    {
        Electronics,
        Electrical,
        Mechanical,
        Computer_Science,
    }
}