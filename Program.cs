using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGrid_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize services and run the application
            var driverService = new Services.DriverService();
            var drivers = driverService.GetAllDrivers();

            foreach (var driver in drivers)
            {
                Console.WriteLine($"Driver ID: {driver.DriverId}, Name: {driver.Name}");
            }

            // Example of getting a specific driver by ID
            var specificDriver = driverService.GetDriverById(1);
            if (specificDriver != null)
            {
                Console.WriteLine($"Found Driver: {specificDriver.Name}");
            }
            else
            {
                Console.WriteLine("Driver not found.");
            }

            // Example of getting drivers by car ID
            var carId = 1; // Example car ID
            var driversByCar = driverService.GetDriversByCarId(carId);
            Console.WriteLine($"Drivers for Car ID {carId}:");
            foreach (var driver in driversByCar)
            {
                Console.WriteLine($"- {driver.Name}");
            }
        }
    }
}