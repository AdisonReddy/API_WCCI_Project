using InnovaDiscs.Models;
using Microsoft.EntityFrameworkCore;

namespace InnovaDiscs.Context
{
    public class InTheBagContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ToDo CHange this to match the data base name as needed
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting2;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<DiscGolfer> DiscGolfer { get; set; }
        public DbSet<Disc> Disc { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InTheBag>().HasKey(ItB => new { ItB.DiscGolfer, ItB.Disc });

            modelBuilder.Entity<DiscGolfer>().HasData(
                new DiscGolfer { DiscGolferId = 1, FirstName = "Adison", LastName = "Reddy", Team = "Innova" });

            modelBuilder.Entity<Disc>().HasData(
                new Disc { DiscId = 1, Brand = "Innova", Name = "Destroyer", Type = "Distance Driver", SpeedInt = 12, GlideInt = 5, TurnInt = -1, FadeInt = 3 },
                new Disc { DiscId = 2, Brand = "Innova", Name = "Teebird", Type = "Fairway Driver", SpeedInt = 7, GlideInt = 5, TurnInt = 0, FadeInt = 2 },
                new Disc { DiscId = 3, Brand = "Innova", Name = "Toro", Type = "Midrange", SpeedInt = 4, GlideInt = 2, TurnInt = 1, FadeInt = 3 },
                new Disc { DiscId = 4, Brand = "Discmania", Name = "Link", Type = "Putter", SpeedInt = 2, GlideInt = 3, TurnInt = 0, FadeInt = 1 });

            
        }
    }
}
