using BreweryManager.Domain.Models;
using BreweryManager.Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Domain.Interfaces.Business
{
    public interface IBreweryManagerBusiness
    {
        Task<List<BeerModel>> GetAllBeersByBrewery(int breweryId);

        BeerModel AddBeer(CreateBeerModel newBeer);
    }
}
