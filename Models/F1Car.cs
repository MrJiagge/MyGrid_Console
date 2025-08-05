using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyGrid_Console.Models
{
    public class F1Car
    {
        public int CarId { get; set; }
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("DriverIds")]
        public required List<int> DriverIds { get; set; }

        [JsonPropertyName("Results")]
        public required List<ConstructorSeasonStats> Results { get; set; }

        [JsonPropertyName("Specs")]
        public required CarPerformanceAndSpecs Specs { get; set; }
    }
}