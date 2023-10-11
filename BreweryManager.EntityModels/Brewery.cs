
using System.ComponentModel.DataAnnotations;

namespace BreweryManager.EntityModels
{
    public class Brewery
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Beer> Beers { get; set; }
    }
}