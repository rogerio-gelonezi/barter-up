using Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Context
{
    public class CatalogContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public CatalogContext()
            : base()
        {
            
        }

        public CatalogContext(DbContextOptions<CatalogContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
