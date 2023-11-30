using fifaAgapov23.Models;
using Microsoft.EntityFrameworkCore;

namespace YourApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Eagles" },
                new Team { Id = 2, Name = "Sharks" },
                new Team { Id = 3, Name = "Lions" },
                new Team { Id = 4, Name = "Knights" }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, FirstName = "John", LastName = "Smith", Gender = "M", DateOfBirth = new DateTime(1990, 5, 21), TeamId = 1, Country = CountryEnum.USA },
                new Player { Id = 2, FirstName = "James", LastName = "Williams", Gender = "M", DateOfBirth = new DateTime(1988, 7, 30), TeamId = 2, Country = CountryEnum.Italy },
                new Player { Id = 3, FirstName = "Robert", LastName = "Johnson", Gender = "M", DateOfBirth = new DateTime(1992, 3, 14), TeamId = 3, Country = CountryEnum.Estonia },
                new Player { Id = 4, FirstName = "Michael", LastName = "Brown", Gender = "M", DateOfBirth = new DateTime(1991, 1, 9), TeamId = 4, Country = CountryEnum.USA },
                new Player { Id = 5, FirstName = "William", LastName = "Jones", Gender = "M", DateOfBirth = new DateTime(1989, 11, 8), TeamId = 1, Country = CountryEnum.Italy },
                new Player { Id = 6, FirstName = "David", LastName = "Miller", Gender = "M", DateOfBirth = new DateTime(1993, 6, 22), TeamId = 2, Country = CountryEnum.Estonia },
                new Player { Id = 7, FirstName = "Richard", LastName = "Davis", Gender = "M", DateOfBirth = new DateTime(1987, 4, 17), TeamId = 3, Country = CountryEnum.USA },
                new Player { Id = 8, FirstName = "Joseph", LastName = "Martinez", Gender = "M", DateOfBirth = new DateTime(1994, 9, 10), TeamId = 4, Country = CountryEnum.Italy }
            );
        }



    }
}
