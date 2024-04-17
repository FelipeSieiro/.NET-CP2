using CHECKPOINT2_DOTNET.Models;
using Microsoft.EntityFrameworkCore;

namespace CHECKPOINT2_DOTNET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> UserFiap { get; set; }
    }
}
