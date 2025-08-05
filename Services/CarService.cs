using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGrid_Console.Models;
using MyGrid_Console.Interfaces;
using System.Text.Json;

namespace MyGrid_Console.Services
{
    public class CarService : ICarService
    {

        private readonly List<F1Car> _cars;

        public CarService()
        {
            _cars = LoadCarsFromJson();
        }

        // TODO: Implement the methods
        public List<F1Car> GetAllCars() => _cars;

        public F1Car? GetCarByCarId(int carId) => _cars.FirstOrDefault(c => c.CarId == carId);

        public List<F1Car> GetCarsByDriverId(int driverId) => [.. _cars.Where(c => c.DriverIds.Contains(driverId))];


        private static List<F1Car> LoadCarsFromJson()
        {
            var json = File.ReadAllText("Data/cars.json");
            return JsonSerializer.Deserialize<List<F1Car>>(json) ?? [];
        }
    }
}