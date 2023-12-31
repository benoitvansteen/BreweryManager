﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.EntityModels
{
    public class Wholesaler
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<WholesalerBeerProduct> WholesalerBeerProducts { get; set; }
        public List<Order> Orders { get; set; }
    }
}
