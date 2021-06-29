using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Models
{
    public class Hotel
    {
        public int propertyId { get; set; }

        public string name { get; set; }

        public int geoId { get; set; }

        public int rating { get; set; }
    } 
}
