using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mk_project.Models
{
    [Table("User")]
    public class UserModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage ="First_Name Required")]
        public string First_Name { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="Last_Name Required")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage ="Gender not specified")]
        public string Gender { get; set; }
        [Required(ErrorMessage ="Mobile no Required")]
        public string Mobile_no { get; set; }

        [Required(ErrorMessage = "Address Required")]
        [StringLength(150)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email id Required")]
       // [RegularExpression(@ "[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email_Id { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [StringLength(100,ErrorMessage ="minimumlength=6")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(100)]
        [Required]
        [Compare("Password",ErrorMessage ="Password does not match")]
        [DataType(DataType.Password)]
        public string Confirm_Password { get; set; }
    }
}