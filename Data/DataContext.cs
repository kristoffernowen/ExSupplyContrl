using Core;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        private DbSet<Order> Orders { get; set; }
    }
}
