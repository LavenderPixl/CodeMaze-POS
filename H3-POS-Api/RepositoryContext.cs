using H3_POS_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace H3_POS_Api
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Item>? Items { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<ServiceSubCategory> ServiceSubCategories { get; set; }


        
    }
}
