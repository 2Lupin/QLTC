using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppQLTC> QLTC { get; set; }
        public DbSet<MRTLine1> MRTLine1 { get; set; }
        public DbSet<MRTLine2> MRTLine2 { get; set; }
        public DbSet<AppTransactions> Transactions { get; set; }
    }
}