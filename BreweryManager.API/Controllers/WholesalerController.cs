using BreweryManager.Domain.Interfaces.Business;
using BreweryManager.Domain.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BreweryManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WholesalerController : Controller
    {
        private readonly ILogger<WholesalerController> _logger;
        private static IWholesalerBusiness _business;
        public WholesalerController(ILogger<WholesalerController> logger, IWholesalerBusiness business)
        {
            _logger = logger;
            _business = business;
        }
        [HttpPost]
        public ActionResult UpdateStockBeer(UpdateWholesalerBeerProduct stockUpdated)
        {
            if (ModelState.IsValid)
            {
                return Ok(_business.UpdateStock(stockUpdated));
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
    }
}
