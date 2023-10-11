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
        public DbSet<Wholesaler> Wholesalers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBeerProduct> OrderBeerProducts { get; set; }
        public DbSet<WholesalerBeerProduct> wholesalerBeerProducts { get; set; }


    }
}
