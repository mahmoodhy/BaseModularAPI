using Microsoft.EntityFrameworkCore;
using Module.Catalog.Core.Data;
using Module.Catalog.Core.Entities;
using Shared.InfraStructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Catalog.InfraStructure.Data
{
    public class CatalogDbContext : ModuleDbContext, ICatalogDbContext
    {
        protected override string Schema => "Catalog";
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
