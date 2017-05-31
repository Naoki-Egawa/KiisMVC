namespace KiisMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KiisDbContext : DbContext
    {
        public KiisDbContext()
            : base("name=KiisDbContext")
        {
        }

        public virtual DbSet<T_CompanyMaster> T_CompanyMaster { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
