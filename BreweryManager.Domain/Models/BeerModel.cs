using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Domain.Models
{
    public class BeerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AlcoolDegree { get; set; }
        public double Price { get; set; }
        public int BreweryId { get; set; }
        public BreweryModel Brewery { get; set; }
    }
}
