using DidoStore.Model.Models;
using System.Data.Entity;

namespace DidoStore.Data
{
    public class DidoStoreDbContext : DbContext
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
