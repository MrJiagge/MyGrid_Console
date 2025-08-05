using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGrid_Console.Models
{
    public class DriverCarStats
    {
        public int CarId { get; set; }
        public int Season { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int Points { get; set; }
        public int Poles { get; set; }
        public int FastestLaps { get; set; }


    }
}