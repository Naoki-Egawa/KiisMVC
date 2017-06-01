namespace KiisMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using KiisMVC.Data;

    public partial class KiisDbContext : DbContext
    {
        public KiisDbContext()
            : base("name=KiisDbContext")
        {
            
        }
        
        
        public virtual DbSet<T_CompanyMaster> T_CompanyMaster { get; set; }
        public virtual DbSet<T_DeliveryService> T_DeliveryServices { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
