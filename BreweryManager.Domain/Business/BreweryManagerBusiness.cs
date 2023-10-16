using BreweryManager.Domain.Interfaces.Business;
using BreweryManager.Domain.Interfaces.Managers;
using BreweryManager.Domain.Models;
using BreweryManager.Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Domain.Business
{
    public class BreweryManagerBusiness : IBreweryManagerBusiness
    {
        public IBreweryManagerManager _breweryManager;
        public BreweryManagerBusiness(IBreweryManagerManager breweryManager) 
        {
            _breweryManager = breweryManager;
        }

        public BeerModel AddBeer(CreateBeerModel newBeer)
        {
            return _breweryManager.AddBeer(newBeer);
        }

        public async Task<List<BeerModel>> GetAllBeersByBrewery(int breweryId)
        {
            return await _breweryManager.GetAllBeersByBrewery(breweryId);
        }
    }
}
