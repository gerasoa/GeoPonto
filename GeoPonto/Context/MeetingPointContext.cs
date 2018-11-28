using Microsoft.EntityFrameworkCore;

namespace GeoPonto.Model
{
    public class MeetingPointContext : DbContext
    {        
        public DbSet<MeetingPoint> MeetingPoint { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=127.0.0.1;database=dbclientes;user=root;password=Senha@123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                 
            //Fluent API
            modelBuilder.Entity<MeetingPoint>(entity =>{
                entity.HasKey(e => e.MeetingPointId);
                entity.HasOne(d => d.User)
                  .WithMany(p => p.MeetingPoints);
            });
        }
    }
}
