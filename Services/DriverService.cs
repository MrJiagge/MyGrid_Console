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
            // Load drivers from a JSON file
            // This method reads the JSON file and deserializes it into a list of F1Driver objects
            // If the file is not found or the JSON is invalid, it will return an empty
            _drivers = LoadDriversFromJson();
        }

        // Public methods to access the drivers
        // These methods are defined in the IDriverService interface and implemented here
        public List<F1Driver> GetAllDrivers() => _drivers;

        // Get a driver by ID
        // This method returns a driver with the specified ID or null if not found
        public F1Driver? GetDriverById(int id) => _drivers.FirstOrDefault(d => d.DriverId == id);

        // Get drivers by car ID
        // This method returns a list of drivers who have stats for the specified car ID
        public List<F1Driver> GetDriversByCarId(int carId)
        {
            // Use LINQ to filter the drivers based on their car stats
            // It checks if any of the driver's car stats match the given car ID
            return [.. _drivers.Where(d => d.CarStats.Any(cs => cs.CarId == carId))]; // list
        }

        // Get car stats for a specific driver
        // This method returns a list of car stats for the driver with the specified ID
        public List<DriverCarStats> GetDriverCarStats(int driverId)
        {
            // Find the driver by ID and return their car stats
            // If the driver is not found, it will return an empty list
            return GetDriverById(driverId)?.CarStats ?? [];
        }

        // Private method to load drivers from a JSON file
        // This method reads the JSON file and deserializes it into a list of F1Driver objects
        // If the file is not found or the JSON is invalid, it will return an empty list
        // This method is private because it is only used within this service
        private static List<F1Driver> LoadDriversFromJson()
        {
            var json = File.ReadAllText("Data/drivers.json");
            return JsonSerializer.Deserialize<List<F1Driver>>(json) ?? [];
        }
    }
}