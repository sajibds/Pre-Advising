using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using project.Models;

namespace project.ViewModel
{
    public class TakeView
    {
        public IEnumerable<course> Courses { get; set; }
        public taken_courses Taken_Courses { get; set; }
        public IEnumerable<Student> students { get; set; }
    }
}