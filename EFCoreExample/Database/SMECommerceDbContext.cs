using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreExample.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Database
{
   public class SMECommerceDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-GTDFCJT;Database=SMECommerceDB_Nasir;Integrated Security=True");
        }
    }
}
