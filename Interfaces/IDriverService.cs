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
        public F1Driver GetDriverByDriverId(int driverId);
        public List<F1Driver> GetDriversByCarId(int carId);
        public List<DriversCarSeasonResults> GetDriversCarSeasonResultsByDriverId(int driverId);
        public F1Driver GetDriverByName(string name);
    }
}