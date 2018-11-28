using GeoPonto.Model;
using Microsoft.EntityFrameworkCore;

namespace GeoPonto.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=127.0.0.1;database=dbclientes;user=root;password=Senha@123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);
            });
        }
    }
}