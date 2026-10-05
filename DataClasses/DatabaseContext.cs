using System;
using Microsoft.EntityFrameworkCore;

namespace Clientibus.DataClasses {
    public class DatabaseContext : DbContext {
        public DbSet<Customer> Customers { get; set; } = null!;

        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                var connectionString = Environment.GetEnvironmentVariable("CLIENTIBUS_CONNECTIONSTRING")
                    ?? "Server=(localdb)\\MSSQLLocalDB;Database=Clientibus;Trusted_Connection=True;MultipleActiveResultSets=true";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
