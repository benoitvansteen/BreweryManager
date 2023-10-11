using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.EntityModels
{
    public class OrderBeerProduct
    {
        public int Id { get; set; }
        [Required]
        public int BeerId { get; set; }
        public Beer Beer { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
