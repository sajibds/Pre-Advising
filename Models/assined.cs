//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class assined
    {
        public string tid { get; set; }
        public string tname { get; set; }
        public string course_code { get; set; }
        public string section { get; set; }
    
        public virtual course course { get; set; }
    }
}
