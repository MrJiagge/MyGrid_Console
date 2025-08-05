using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MyGrid_Console.Interfaces;
using MyGrid_Console.Models;

namespace MyGrid_Console.Services
{

    public class DriverService : IDriverService
    {

        private readonly List<F1Driver> _drivers;

        public DriverService()
        {
            _drivers = LoadDriversFromJson();
        }

        public List<F1Driver> GetAllDrivers() => _drivers;

        private static List<F1Driver> LoadDriversFromJson()
        {
            var json = File.ReadAllText("Data/drivers.json");
            return JsonSerializer.Deserialize<List<F1Driver>>(json) ?? [];
        }

        public F1Driver GetDriverByDriverId(int driverId) =>
        _drivers.FirstOrDefault(d => d.DriverId == driverId)
        ?? throw new KeyNotFoundException($"Driver with ID {driverId} not found.");

        public List<F1Driver> GetDriversByCarId(int carId) =>
            [.. _drivers.Where(d => d.SeasonResults.Any(sr => sr.CarId == carId))];

        public List<DriversCarSeasonResults> GetDriversCarSeasonResultsByDriverId(int driverId) =>
            _drivers.FirstOrDefault(d => d.DriverId == driverId)?.SeasonResults
            ?? throw new KeyNotFoundException($"Driver with ID {driverId} not found or has no season results.");
    }
}