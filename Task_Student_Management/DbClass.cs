using Microsoft.EntityFrameworkCore;
using Task_Student_Management.DTO;
using Task_Student_Management.Tables;

namespace Task_Student_Management
{
    public class DbClass :DbContext
    {
        public DbSet<Registration> Registration { get; set; }
        public DbSet<DTOMessage> RegisterUser { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }

        public DbSet<DTOReturn> LoginCheck { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Students> UpdateStudent { get; set; }


        public DbClass() { }
        public DbClass(DbContextOptions<DbClass> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().HasNoKey();
            modelBuilder.Entity<DTOMessage>().HasNoKey();
            modelBuilder.Entity<Hobbies>().HasNoKey();
            modelBuilder.Entity<Students>().HasNoKey();
            modelBuilder.Entity<DTOReturn>().HasNoKey();
        }
    }
}
