using Microsoft.AspNetCore.Mvc;
using PruebaApi.Models;
using PruebaApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Controllers
{
    [Route ("api/[controller]")]
    public class HotelController : Controller
    {
        private HotelSV hotelsv;


        [HttpGet("{nights}/{destinationId}")]
        public async Task<List<Record>> GetHotels(int nights, int destinationId)
        {
            if (nights <= 0)
            {
                //Tratar la excepción
            }

            hotelsv = new HotelSV(nights, destinationId);

            var hoteles = await hotelsv.getHotels();

            foreach(var iterator in hoteles)
            {
                for(int i =0; i<iterator.rates.Length; i++)
                {
                    if(iterator.rates[i].rateTypeBool){         //rateTypeBool es true cuando la reserva es por noche
                        iterator.rates[i].value = nights * iterator.rates[i].value;
                    }
                }
            }
            return hoteles;
        }
    }
}
