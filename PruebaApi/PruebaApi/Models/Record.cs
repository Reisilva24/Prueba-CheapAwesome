using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Models
{
    public class Record
    {
        public Hotel hotel { get; set; }
        public Rate [] rates { get; set; }
    }
}
