﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResumeProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbResumeEntities5 : DbContext
    {
        public DbResumeEntities5()
            : base("name=DbResumeEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLPROFILE> TBLPROFILE { get; set; }
        public virtual DbSet<TBLPROJECT> TBLPROJECT { get; set; }
        public virtual DbSet<TBLSKILL> TBLSKILL { get; set; }
        public virtual DbSet<TBLTECNOLOGY> TBLTECNOLOGY { get; set; }
        public virtual DbSet<TBLCONTACT> TBLCONTACT { get; set; }
        public virtual DbSet<TBLCATEGORY> TBLCATEGORY { get; set; }
    }
}
