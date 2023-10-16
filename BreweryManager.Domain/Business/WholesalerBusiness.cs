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
    public class WholesalerBusiness : IWholesalerBusiness
    {
        public IBreweryManagerManager _breweryManager;
        public WholesalerBusiness(IBreweryManagerManager breweryManager)
        {
            _breweryManager = breweryManager;
        }

        public WholesalerBeerProductModel UpdateStock(UpdateWholesalerBeerProduct stockUpdated)
        {
            return _breweryManager.UpdateStock(stockUpdated);
        }
    }
}
