﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEEIPro.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class seeiExpertsDBEntities : DbContext
    {
        public seeiExpertsDBEntities()
            : base("name=seeiExpertsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<StorageStatu> StorageStatus { get; set; }
        public DbSet<UnitProperty> UnitProperties { get; set; }
        public DbSet<ExpertBankInfo> ExpertBankInfoes { get; set; }
        public DbSet<ExpertExperience> ExpertExperiences { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}