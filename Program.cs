using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGrid_Console.Services;
using MyGrid_Console.Models;
using MyGrid_Console.Interfaces;

namespace MyGrid_Console
{}
    public class Program
    {
    public static void Main(string[] args)
    {
        CarService carService = new();
        DriverService driverService = new();
        List<F1Driver> drivers = driverService.GetAllDrivers();

        Console.WriteLine("List of F1 Drivers:");
        // wait 2 seconds before displaying the list
        Task.Delay(2000).Wait();
        foreach (var driver in drivers)
        {
            Console.WriteLine($"Driver ID: {driver.DriverId}, Name: {driver.Name}");
        }

        Task.Delay(1000).Wait();

        Console.Write("Enter Driver ID to get details: ");
        int selectedDriverId = int.Parse(Console.ReadLine() ?? "0");
        F1Driver selectedDriver = driverService.GetDriverByDriverId(selectedDriverId);
        // get ONLY the names of the cars driven by the selected driver
        var carsDriven = selectedDriver?.SeasonResults?
            .Select(sr => carService.GetCarByCarId(sr.CarId)?.Name)
            .Where(name => !string.IsNullOrEmpty(name))
            .Distinct()
            .ToList() ?? [];

        foreach (var carName in carsDriven)
        {
            Console.WriteLine($"Car Driven: {carName}");
        }
        

    }   
}

