using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DbContextBase: DbContext
    {
        public DbContextBase(DbContextOptions<DbContextBase> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
