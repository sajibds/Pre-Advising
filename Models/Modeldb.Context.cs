﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projectprtEntities5 : DbContext
    {
        public projectprtEntities5()
            : base("name=projectprtEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assined> assineds { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<semester> semesters { get; set; }
        public virtual DbSet<taken_courses> taken_courses { get; set; }
    }
}
