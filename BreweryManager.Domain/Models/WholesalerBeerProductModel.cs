using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Domain.Models
{
    public class WholesalerBeerProductModel
    {
        public int Id { get; set; }
        public int WholesalerId { get; set; }
        public int BeerId { get; set; }
        public int Stock { get; set; }
    }
}
