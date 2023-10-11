using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.EntityModels
{
    public class WholesalerBeerProduct
    {
        public int Id { get; set; }
        [Required] 
        public int WholesalerId { get; set; }
        public Wholesaler Wholesaler { get; set; }
        [Required]
        public int BeerId { get; set; }
        public Beer Beer { get; set; }
        public int Stock { get; set; }
    }
}
