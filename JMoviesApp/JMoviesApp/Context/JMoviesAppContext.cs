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
        public DbSet<Customer> Customer { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

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
        }



    }
}
