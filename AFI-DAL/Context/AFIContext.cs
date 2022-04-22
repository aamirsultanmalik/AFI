using AFI_DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFI_DAL.Context
{
    public class AFIContext : DbContext 
    {
        public AFIContext()
        {
        }
        public AFIContext(DbContextOptions options): base(options) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AFI;Integrated Security= True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
