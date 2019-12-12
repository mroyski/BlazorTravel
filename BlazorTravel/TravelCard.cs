using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTravel
{
    public class TravelCard
    {
        public int TravelCardId { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public int NumberOfDays { get; set; }
        public decimal Price { get; set; }
    }
}
