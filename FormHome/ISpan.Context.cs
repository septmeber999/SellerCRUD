//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormHome
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IspanEntities : DbContext
    {
        public IspanEntities()
            : base("name=IspanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrators> Administrators { get; set; }
        public virtual DbSet<BlacklistedMembers> BlacklistedMembers { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Coupons> Coupons { get; set; }
        public virtual DbSet<LoginHistory> LoginHistory { get; set; }
        public virtual DbSet<MemberAddresses> MemberAddresses { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<MemberServiceDetails> MemberServiceDetails { get; set; }
        public virtual DbSet<MemberServiceRecord> MemberServiceRecord { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ProductFlavors> ProductFlavors { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductSizes> ProductSizes { get; set; }
        public virtual DbSet<Sellers> Sellers { get; set; }
        public virtual DbSet<SellerServiceDetails> SellerServiceDetails { get; set; }
        public virtual DbSet<SellerServiceRecord> SellerServiceRecord { get; set; }
        public virtual DbSet<Suspensions> Suspensions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
