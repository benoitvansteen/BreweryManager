using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryManager.EntityModels
{
    public class Beer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double AlcoolDegree { get; set; }
        public double Price { get; set;}
        [Required]
        public int BreweryId { get; set; }
        public Brewery Brewery{ get; set; }
    }
}
