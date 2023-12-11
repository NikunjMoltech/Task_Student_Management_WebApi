using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DAL_studentManagementTask
{
    public class DbClass : DbContext
    {
        public DbClass() { }
        public DbClass(DbContextOptions<DbClass> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
