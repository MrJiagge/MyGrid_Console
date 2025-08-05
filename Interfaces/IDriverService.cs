using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGrid_Console.Models;

namespace MyGrid_Console.Interfaces
{
    public interface IDriverService
    {
        public List<F1Driver> GetAllDrivers();
        public F1Driver? GetDriverById(int driverId); // can be null if not found
        public List<F1Driver> GetDriversByCarId(int carId);
        public List<DriverCarStats> GetDriverCarStats(int driverId);
    }
}