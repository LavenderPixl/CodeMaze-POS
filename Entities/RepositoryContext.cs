using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Sale>? Sales { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<ServiceCategory>? ServiceCategories { get; set; }
        public DbSet<ServiceSubCategory>? ServiceSubCategories { get; set; }
    }
}