﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplyingApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ApplyDataBaseEntities : DbContext
    {
        public ApplyDataBaseEntities()
            : base("name=ApplyDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApplyInfo> ApplyInfoes { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<Financing> Financings { get; set; }
        public virtual DbSet<FormOfEducation> FormOfEducations { get; set; }
        public virtual DbSet<FullSpecialityInfo> FullSpecialityInfoes { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
    }
}
