using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.Domain.Models.Request
{
    public class UpdateWholesalerBeerProduct
    {
        [Required]
        public int BeerId { get; set; }
        [Required]
        public int WholesalerId { get; set; }
        [Required]
        public int UpdatedStock { get; set; }
    }
}
