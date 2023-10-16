using BreweryManager.Domain.Interfaces.Managers;
using BreweryManager.Domain.Models;
using BreweryManager.Domain.Models.Request;
using BreweryManager.EntityModels;
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

        public BeerModel AddBeer(CreateBeerModel newBeer)
        {
            var beer = new Beer
            {
                Name = newBeer.Name,
                AlcoolDegree = newBeer.AlcoolDegree,
                BreweryId = newBeer.BreweryId,
                Price = newBeer.Price
            };
            _dataContext.Beers.Add(beer);
            _dataContext.SaveChanges();
            var beerModel = new BeerModel
            {
                Id = beer.Id,
                Name = beer.Name,
                AlcoolDegree = beer.AlcoolDegree,
                BreweryId = beer.BreweryId,
                Price = beer.Price
            };
            return beerModel;
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
                    Name = bm.Name,
                    Price = bm.Price
                }
            ).ToListAsync();
            foreach (var beer in beers)
            {
                var wholesalers = _dataContext.wholesalerBeerProducts.Where(b => b.BeerId == beer.Id).Select(w => 
                    new WholesalerModel
                    {
                        Id = w.Wholesaler.Id,
                        Name = w.Wholesaler.Name
                    }).Distinct();
                if (wholesalers.Count()>0)
                {
                    beer.Wholesalers = wholesalers.ToList();
                }
            }
            return beers;
        }
    }
}
