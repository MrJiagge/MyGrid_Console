using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGrid_Console.Models
{
    public class F1Driver
    {
        public int DriverId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public required List<DriversCarSeasonResults> SeasonResults { get; set; } = [];
        
    }
}