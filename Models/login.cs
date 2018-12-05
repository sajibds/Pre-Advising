using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class login
    {
        [DisplayName("Student Id")]
        [Required(ErrorMessage = "This feild is required")]
        public string student_Id { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "This feild is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}