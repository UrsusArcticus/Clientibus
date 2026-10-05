using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Clientibus.DataClasses {
    internal class DatabaseContext : DbContext {
        public DbSet<Customer> Customers { get; set; } = null!;
        

    }
}
