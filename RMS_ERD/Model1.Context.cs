//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMS_ERD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecruitmentManagementSystemDBEntities : DbContext
    {
        public RecruitmentManagementSystemDBEntities()
            : base("name=RecruitmentManagementSystemDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<AdresaAplikanta> AdresaAplikantas { get; set; }
        public virtual DbSet<AdresaKompanije> AdresaKompanijes { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Obrazovanje> Obrazovanjes { get; set; }
        public virtual DbSet<Ogla> Oglas { get; set; }
        public virtual DbSet<ProfilAplikanta> ProfilAplikantas { get; set; }
        public virtual DbSet<ProfilKompanije> ProfilKompanijes { get; set; }
        public virtual DbSet<RadnoIskustvo> RadnoIskustvoes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Vjestine> Vjestines { get; set; }
    }
}
