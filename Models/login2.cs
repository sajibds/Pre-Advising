using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class login2
    {
        [DisplayName("Admin Id")]
        [Required(ErrorMessage = "This feild is required")]
        public string Admin_Id { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "This feild is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}