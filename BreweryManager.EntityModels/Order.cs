using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.EntityModels
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int WholesalerId { get; set; }
        public Wholesaler Wholesaler { get; set; }
        public List<OrderBeerProduct> OrderBeerProducts { get; set; }
        public double Price { get; set; }
    }
}
