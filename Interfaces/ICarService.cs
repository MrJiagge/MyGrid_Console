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
        public F1Car? GetCarByCarId(int carId);

        public List<F1Car> GetCarsByDriverId(int driverId);
    }
}