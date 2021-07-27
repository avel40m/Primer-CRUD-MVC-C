using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudNetCore5.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNetCore5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Libro> Libros { get; set; }
    }
}