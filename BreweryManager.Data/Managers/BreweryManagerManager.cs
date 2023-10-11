using BreweryManager.Domain.Interfaces.Managers;
using BreweryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Data.Managers
{
    public class BreweryManagerManager : IBreweryManagerManager
    {
        private readonly DataContext _dataContext;

        public BreweryManagerManager(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<BeerModel>> GetAllBeersByBrewery(int breweryId)
        {
            var beers = await _dataContext.Beers.Where(b=>b.BreweryId == breweryId).Select(bm=> 
                new BeerModel 
                {
                    Id = bm.Id,
                    BreweryId = bm.BreweryId,
                    AlcoolDegree = bm.AlcoolDegree,
                    Brewery = new BreweryModel 
                    {
                        Id = bm.Brewery.Id,
                        Name = bm.Brewery.Name
                    },
                    Name = bm.Brewery.Name,
                    Price = bm.Price
                }
            ).ToListAsync();
            return beers;
        }
    }
}
