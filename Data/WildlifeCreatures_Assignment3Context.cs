using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WildlifeCreatures_Assignment3.Models;

namespace WildlifeCreatures_Assignment3.Data
{
    // DbContext class responsible for interacting with the database
    public class WildlifeCreatures_Assignment3Context : DbContext
    {
        // Constructor accepting DbContextOptions
        public WildlifeCreatures_Assignment3Context(DbContextOptions<WildlifeCreatures_Assignment3Context> options)
            : base(options)
        {
        }

        // DbSet representing the WildlifeModel table in the database
        // DbSet<> properties represent database tables
        public DbSet<WildlifeCreatures_Assignment3.Models.WildlifeModel> WildlifeModel { get; set; } = default!;
    }
}
