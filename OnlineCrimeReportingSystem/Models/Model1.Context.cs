﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineCrimeReportingSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A44DBC_milanadhikari09Entities : DbContext
    {
        public DB_A44DBC_milanadhikari09Entities()
            : base("name=DB_A44DBC_milanadhikari09Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminCriminalRecord> AdminCriminalRecords { get; set; }
        public virtual DbSet<AdminProfile> AdminProfiles { get; set; }
        public virtual DbSet<ContactUsMessage> ContactUsMessages { get; set; }
        public virtual DbSet<Crime> Crimes { get; set; }
        public virtual DbSet<CrimeType> CrimeTypes { get; set; }
        public virtual DbSet<Criminal> Criminals { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
    }
}
