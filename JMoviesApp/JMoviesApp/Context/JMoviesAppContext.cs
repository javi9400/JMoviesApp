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



    }
}
