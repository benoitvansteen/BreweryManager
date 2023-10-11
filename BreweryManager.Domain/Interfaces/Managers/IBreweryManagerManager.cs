using BreweryManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Domain.Interfaces.Managers
{
    public interface IBreweryManagerManager
    {
        Task<List<BeerModel>> GetAllBeersByBrewery(int breweryId);
    }
}
