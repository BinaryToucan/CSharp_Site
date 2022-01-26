using Lab7_mel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7_mel.Data
{
    public class DBcarContext : DbContext
    {
        public DBcarContext() : this(false)
        { }
        public DBcarContext(bool bFromScratch) : base()
        {
            if (bFromScratch)
            {
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        public DBcarContext(DbContextOptions<DBcarContext> options)
        : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder

               .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DBcar;Trusted_connection=TRUE");
            }
        }
        // Коллекции сущностей
        public DbSet<Car> Cars { get; set; }
        public DbSet<Generator> Generators { get; set; }
    }
}
