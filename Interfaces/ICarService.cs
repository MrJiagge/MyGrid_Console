using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGrid_Console.Models;

namespace MyGrid_Console.Interfaces
{
    public interface ICarService
    {
        public List<F1Car> GetAllCars();
        public F1Car? GetCarById(int carId); // can be null if not found

        // Get a list of cars driven by a specific driver
        public List<F1Car> GetCarsByDriverId(int driverId);
    }
}