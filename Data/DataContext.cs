using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        //  To get rid of the warning above that is on the DataContext, use this line for the DbSet
        // public DbSet<Character> Characters => Set<Character>();

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}