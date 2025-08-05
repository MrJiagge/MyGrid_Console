using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGrid_Console.Services;
using MyGrid_Console.Models;

namespace MyGrid_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize services and run the application
            var driverService = new DriverService();
            var carService = new CarService();

            // example of getting drivers from car id
            var carId = 1; // example car id
            var driversByCar = driverService.GetDriversByCarId(carId);
            var carFromCarId = carService.GetCarById(carId);
            Console.WriteLine($"Car ID {carId}: {carFromCarId?.Name}");
            Console.WriteLine($"Drivers for Car ID {carId}:");
            foreach (var driver in driversByCar)
            {
                Console.WriteLine($"- {driver.Name} (ID: {driver.DriverId})");
            }
        }
    }
}