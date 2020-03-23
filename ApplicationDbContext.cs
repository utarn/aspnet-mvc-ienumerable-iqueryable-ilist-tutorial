using System;
using System.Collections.Generic;
using LinqCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class ApplicationDbContext : DbContext
{
   public DbSet<Movie> Movies { get; set; }
   public static readonly ILoggerFactory MyLoggerFactory
           = LoggerFactory.Create(builder => { builder.AddConsole(); });
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder
      .UseLoggerFactory(MyLoggerFactory)
      .UseNpgsql(@"Host=localhost;Port=5433;User Id=postgres;Password=password;Database=movie_sample");
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<Movie>().HasKey(m => m.Id);
      modelBuilder.Entity<Movie>().Property(m => m.Id).UseIdentityAlwaysColumn();
      modelBuilder.Entity<Movie>().HasData(
         new List<Movie>() {
             new Movie
                    {
                        Id = 1,
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Id = 2,
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Id = 3,
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Id = 4,
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
        }
      );

   }
}