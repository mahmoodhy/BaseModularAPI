using Microsoft.EntityFrameworkCore;
using Module.Catalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Catalog.Core.Data
{
    public interface ICatalogDbContext
    {
        public DbSet<Brand> Brands { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
