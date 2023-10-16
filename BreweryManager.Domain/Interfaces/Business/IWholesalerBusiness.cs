using BreweryManager.Domain.Models.Request;
using BreweryManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Domain.Interfaces.Business
{
    public interface IWholesalerBusiness
    {
        WholesalerBeerProductModel UpdateStock(UpdateWholesalerBeerProduct stockUpdated);

    }
}
