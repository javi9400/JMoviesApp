using JMoviesApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JMoviesApp.Context
{
    public class JMoviesAppContext:DbContext
    {
        public JMoviesAppContext(DbContextOptions<JMoviesAppContext> context) : base(context)
        {

        }
     
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType()
                {
                    Id = 1,
                    SignUpFee = 0,
                    DurationInMonths = 0,
                    DiscountRate = 0

                },
                new MembershipType()
                {
                    Id = 2,
                    SignUpFee = 30,
                    DurationInMonths = 1,
                    DiscountRate = 10

                },
                new MembershipType()
                {
                    Id = 3,
                    SignUpFee = 3,
                    DurationInMonths = 90,
                    DiscountRate = 15

                },
                new MembershipType()
                {
                    Id = 4,
                    SignUpFee = 300,
                    DurationInMonths = 12,
                    DiscountRate = 15

                });

            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer()
                {
                    Id = 1,
                    Name = "Javier",
                    IsSuscribedToNewsLetter=true,
                    MembershipTypeId=1
                    
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Daniella",
                    IsSuscribedToNewsLetter = true,
                    MembershipTypeId = 1
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Carlos",
                    IsSuscribedToNewsLetter = false,
                    MembershipTypeId=2
                }

                );

            modelBuilder.Entity<Genre>().HasData(
                 new Genre()
                 {
                     Id = 1,
                     Name = "Comedy"
                 },
                new Genre()
                {
                    Id = 2,
                    Name = "Thriller"
                },
                new Genre()
                {
                    Id = 3,
                    Name = "Fiction"
                },
                new Genre()
                {
                    Id = 4,
                    Name = "Love"
                },
                new Genre()
                {
                    Id = 5,
                    Name = "Documental"
                },
                new Genre()
                  {
                      Id = 6,
                      Name = "Action"
                  },
                
                  new Genre()
                    {
                        Id = 7,
                        Name = "Documental"
                    }
                  );
            
            modelBuilder.Entity<Movie>()
                .HasData(
                new Movie()
                {
                    Id = 1,
                    Name = "Star wars",
                    GenreId=3,
                    ReleaseDate=new DateTime(1985,12,7),
                    DateAdded=new DateTime(1994,12,1)
                    
                },
                new Movie()
                {
                    Id = 2,
                    Name = "SpiderMan",
                    GenreId = 3,
                    ReleaseDate = new DateTime(2018, 12, 7),
                    DateAdded = new DateTime(2019, 4, 1)

                },
                new Movie()
                {
                    Id = 3,
                    Name = "John Wick",
                    GenreId = 6,
                    ReleaseDate = new DateTime(2019, 12, 7),
                    DateAdded = new DateTime(2020, 6, 1)
                }

                );

            modelBuilder.Entity<Customer>()
                .Property(s => s.Name)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(s => s.Name)
                .HasMaxLength(255)
                .IsRequired();


        }



    }
}
