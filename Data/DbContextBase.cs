using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DbContextBase: DbContext
    {
        public DbContextBase(DbContextOptions<DbContextBase> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
