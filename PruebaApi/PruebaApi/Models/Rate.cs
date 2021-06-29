using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Models
{
    public class Rate
    {
        public string rateType { get; set; } 

        public bool rateTypeBool  => rateType.Equals("PerNight"); // 1 si es por noche 0 si es stay

        public string boardType { get; set; }

        public double value { get; set; }
    }
}
