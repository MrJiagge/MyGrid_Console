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

            List<F1Car> allCars = carService.GetAllCars();

        for (int i = 0; i < allCars.Count; i++)
        {
            Console.WriteLine($"Car ID: {allCars[i].CarId}, Name: {allCars[i].Name}");
        }
    }   
}

