using DidoStore.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DidoStore.Data
{
    public class DidoStoreDbContext : IdentityDbContext<ApplicationUser>
    {
        public DidoStoreDbContext() : base("DidoStoreConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Branch> Branches { set; get; }
        public DbSet<Comment> Comments { set; get; }
        public DbSet<CommentDetail> CommentDetails { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Rating> Ratings { set; get; }
        public DbSet<Error> Errors { set; get; }

        public static DidoStoreDbContext Create()
        {
            return new DidoStoreDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>().HasKey(i => new {i.UserId, i.RoleId });
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}
