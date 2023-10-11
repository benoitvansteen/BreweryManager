using BreweryManager.EntityModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BreweryManager.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Beer> Beers { get; set; }
    }
}
