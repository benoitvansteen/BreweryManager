using BreweryManager.Domain.Interfaces.Business;
using BreweryManager.Domain.Models;
using BreweryManager.EntityModels;
using Microsoft.AspNetCore.Mvc;

namespace BreweryManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreweryController : ControllerBase
    {
       
        private readonly ILogger<BreweryController> _logger;
        private static IBreweryManagerBusiness _business;

        public BreweryController(ILogger<BreweryController> logger, IBreweryManagerBusiness business)
        {
            _logger = logger;
            _business = business;
        }

        [HttpGet("{breweryId}/beers")]
        public async Task<ActionResult<List<BeerModel>>> GetAllBeersByBrewery(int breweryId)
        {
            var beers = await _business.GetAllBeersByBrewery(breweryId);
            return beers;
        }

        [HttpGet(Name = "GetBrewery")]
        public IEnumerable<Brewery> Get()
        {
           var breweries = new List<Brewery>();
            breweries.Add(new Brewery
            {
                Id = 1,
                Name = "Saint Feuillien"
            });
            return breweries;
        }
    }
}