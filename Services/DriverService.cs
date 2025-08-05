using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MyGrid_Console.Interfaces;
using MyGrid_Console.Models;

namespace MyGrid_Console.Services
{
    // using the interface to define the service
    // Interface Segregation Principle (ISP) is applied here from SOLID principles
    public class DriverService : IDriverService
    {
        // immutable list of drivers
        // this is a private field that holds the list of drivers
        private readonly List<F1Driver> _drivers;

        // Constructor that initializes the drivers list from a JSON file
        // This constructor is called when the service is instantiated
        public DriverService()
        {
            _drivers = LoadDriversFromJson();
        }

        // Public methods to access the drivers
        // These methods are defined in the IDriverService interface and implemented here
        public List<F1Driver> GetAllDrivers() => _drivers;


        public F1Driver? GetDriverById(int id) => _drivers.FirstOrDefault(d => d.DriverId == id);


        public List<F1Driver> GetDriversByCarId(int carId) => [.. _drivers.Where(d => d.CarsDrivenAndStats.Any(cs => cs.CarId == carId))];


        public List<DriverCarStats> GetDriverCarStats(int driverId)
        {
            return GetDriverById(driverId)?.CarsDrivenAndStats ?? [];
        }

        private static List<F1Driver> LoadDriversFromJson()
        {
            var json = File.ReadAllText("Data/drivers.json");
            return JsonSerializer.Deserialize<List<F1Driver>>(json) ?? [];
        }
    }
}