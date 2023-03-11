using InnovaDiscs.Models;
using Microsoft.EntityFrameworkCore;

namespace InnovaDiscs.Context
{
    public class InnovaDiscsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ToDo CHange this to match the data base name as needed
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DiscGolf;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscGolfer>().HasData(
                new DiscGolfer { Id = 1, FirstName = "Adison", LastName = "Reddy", Team = "Innova" });

            modelBuilder.Entity<Disc>().HasData(
                new Disc { Id = 1, Brand = "Innova", Name = "Destroyer", Type = "Distance Driver", SpeedInt = 12, GlideInt = 5, TurnInt = -1, FadeInt = 3 },
                new Disc { Id = 2, Brand = "Innova", Name = "Teebird", Type = "Fairway Driver", SpeedInt = 7, GlideInt = 5, TurnInt = 0, FadeInt = 2 },
                new Disc { Id = 3, Brand = "Innova", Name = "Toro", Type = "Midrange", SpeedInt = 4, GlideInt = 2, TurnInt = 1, FadeInt = 3 },
                new Disc { Id = 4, Brand = "Discmania", Name = "Link", Type = "Putter", SpeedInt = 2, GlideInt = 3, TurnInt = 0, FadeInt = 1 });
        }
        public DbSet<DiscGolfer> DiscGolfers { get; set; }
        public DbSet<Disc> Discs { get; set; }
    }
}
