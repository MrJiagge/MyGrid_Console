using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGrid_Console.Models
{
    public class F1Car
    {
        public int CarId { get; set; }
        public string Name { get; set; } = string.Empty;
        public required List<int> DriverIds { get; set; }
    }
}