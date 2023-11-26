using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Client> Client { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-B60AFKK; Database=virtualstore;User Id=sa;Password=marcos123;trusted_connection=true;Encrypt=false");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DiasLibres>(entity =>
            //{
            //    entity.Property(p => p.ETA_Puerto)
            //        .HasDefaultValue("-");
            //});
        }
    }
}
