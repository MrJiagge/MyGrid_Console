using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGrid_Console.Models
{
    public class ConstructorSeasonStats
    {
        public int CarId { get; set; }
        public int Year { get; set; }
        public int PlaceInConstructorChampionship { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int Poles { get; set; }
        public int FastestLaps { get; set; }
    }
}