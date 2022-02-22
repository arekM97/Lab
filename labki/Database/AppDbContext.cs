using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace labki.Database
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public AppDbContext(DbContextOptions options)
        : base(options)
        {
        }
    }
}
